using Lms.Data.Models.Delib;
using Lms.Data.Models.Delocal;
using Lms.Data.Models.Decat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Lms.Data
{
    public class BorrowerImportService : IBorrowerImportService
    {
        private readonly DelibContext _delib;
        private readonly DelocalContext _delocal;
        private readonly DecatContext _decat;

        public BorrowerImportService(DelibContext delib, DelocalContext delocal, DecatContext decat)
        {
            _delib = delib;
            _delocal = delocal;
            _decat = decat;
        }

        public async Task<List<ImportBorTemplate>> GetAvailableTemplatesAsync()
        {
            return await _delocal.ImportBorTemplates
                .OrderBy(t => t.TemplateName)
                .ToListAsync();
        }

        public async Task<ImportResult> ProcessImportTemplateAsync(int templateId, Stream fileStream)
        {
            var result = new ImportResult { Success = true };
            if (fileStream == null || fileStream.Length == 0)
            {
                result.Success = false;
                result.Errors.Add("No file data provided.");
                return result;
            }

            try
            {
                var template = await _delocal.ImportBorTemplates.FirstOrDefaultAsync(t => t.TemplateId == templateId);
                if (template == null)
                {
                    result.Success = false;
                    result.Errors.Add("Template not found.");
                    return result;
                }

                var details = await _delocal.ImportBorTemplateDetails
                    .Where(d => d.TemplateId == templateId)
                    .OrderBy(d => d.SortId)
                    .ToListAsync();

                if (!details.Any())
                {
                    result.Success = false;
                    result.Errors.Add("Template has no columns defined.");
                    return result;
                }

                var colIds = details.Select(d => d.ColId).ToList();
                var sysCols = await _delocal.ImportBorTemplateSysColumns
                    .Where(c => colIds.Contains(c.Pkid))
                    .ToDictionaryAsync(c => c.Pkid, c => c.ColName);

                using var reader = new StreamReader(fileStream);
                var tempImports = new List<TempBorImport>();

                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    result.ProcessedCount++;
                    var values = line.Split(',');
                    var tempImport = new TempBorImport
                    {
                        RecordedDatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Status = "STAGED",
                        ImportType = "TEMPLATE",
                        LibGroupId = template.LibGroupId.ToString()
                    };

                    for (int i = 0; i < details.Count; i++)
                    {
                        if (i >= values.Length) break;

                        var detail = details[i];
                        if (sysCols.TryGetValue(detail.ColId, out var colName) && !string.IsNullOrEmpty(colName))
                        {
                            var val = values[i].Trim();
                            if (detail.IsMandatory && string.IsNullOrEmpty(val))
                            {
                                // Handle mandatory field missing if needed
                            }

                            // Map colName to property. We assume ColName matches property name or can be mapped easily.
                            // Convert snake_case to PascalCase if necessary, e.g., BOR_SURNAME -> BorSurname
                            var propName = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(colName.ToLower().Replace("_", " ")).Replace(" ", "");
                            var prop = typeof(TempBorImport).GetProperty(propName);
                            if (prop != null && prop.CanWrite)
                            {
                                prop.SetValue(tempImport, val);
                            }
                        }
                    }

                    tempImports.Add(tempImport);
                    result.SuccessCount++;
                }

                if (tempImports.Any())
                {
                    _delib.TempBorImports.AddRange(tempImports);
                    await _delib.SaveChangesAsync();
                }

                result.Message = $"Successfully staged {result.SuccessCount} users for import.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add($"System error: {ex.Message}");
            }

            return result;
        }

        public async Task<ImportResult> ProcessImportPicturesAsync(Stream zipStream)
        {
            var result = new ImportResult { Success = true };
            if (zipStream == null || zipStream.Length == 0)
            {
                result.Success = false;
                result.Errors.Add("No file data provided.");
                return result;
            }

            try
            {
                using var archive = new ZipArchive(zipStream, ZipArchiveMode.Read);

                foreach (var entry in archive.Entries)
                {
                    if (string.IsNullOrEmpty(entry.Name) || entry.Name.EndsWith("/")) continue;

                    result.ProcessedCount++;
                    var barcode = Path.GetFileNameWithoutExtension(entry.Name);
                    var extension = Path.GetExtension(entry.Name).ToLower();
                    
                    var borrower = await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorBarNo == barcode);
                    if (borrower == null)
                    {
                        result.ErrorCount++;
                        result.Errors.Add($"User not found for barcode: {barcode} (from file {entry.Name})");
                        continue;
                    }

                    // Determine Content Type
                    string contentType = extension switch
                    {
                        ".jpg" or ".jpeg" => "image/jpeg",
                        ".png" => "image/png",
                        ".gif" => "image/gif",
                        _ => "application/octet-stream"
                    };

                    using var entryStream = entry.Open();
                    using var ms = new MemoryStream();
                    await entryStream.CopyToAsync(ms);
                    var data = ms.ToArray();

                    var existingPic = await _delib.ABorPictures.FindAsync(borrower.BorNo);
                    if (existingPic != null)
                    {
                        existingPic.BorPicData = data;
                        existingPic.BorPicFilename = entry.Name;
                        existingPic.BorPicType = contentType;
                    }
                    else
                    {
                        _delib.ABorPictures.Add(new ABorPicture
                        {
                            BorNo = borrower.BorNo,
                            BorPicData = data,
                            BorPicFilename = entry.Name,
                            BorPicType = contentType
                        });
                    }

                    result.SuccessCount++;
                }

                await _delib.SaveChangesAsync();
                result.Message = $"Successfully imported {result.SuccessCount} pictures.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add($"System error processing ZIP: {ex.Message}");
            }

            return result;
        }

        public async Task<ImportResult> ProcessImportGroupAsync(Stream fileStream)
        {
            var result = new ImportResult { Success = true };
            if (fileStream == null || fileStream.Length == 0)
            {
                result.Success = false;
                result.Errors.Add("No file data provided.");
                return result;
            }

            try
            {
                using var reader = new StreamReader(fileStream);
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    result.ProcessedCount++;
                    var parts = line.Split(',');
                    if (parts.Length < 2)
                    {
                        result.ErrorCount++;
                        result.Errors.Add($"Invalid line format at row {result.ProcessedCount}: {line}");
                        continue;
                    }

                    var barcode = parts[0].Trim();
                    var groupCode = parts[1].Trim();

                    var borrower = await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorBarNo == barcode);
                    if (borrower == null)
                    {
                        result.ErrorCount++;
                        result.Errors.Add($"Borrower not found for barcode: {barcode}");
                        continue;
                    }

                    borrower.BorGroup = groupCode;
                    borrower.BorDatetime = DateTime.Now;
                    result.SuccessCount++;
                }

                await _delib.SaveChangesAsync();
                result.Message = $"Successfully updated {result.SuccessCount} user groups.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add($"System error: {ex.Message}");
            }

            return result;
        }

        public async Task<ImportResult> ProcessImportClassAsync(Stream fileStream)
        {
            var result = new ImportResult { Success = true };
            if (fileStream == null || fileStream.Length == 0)
            {
                result.Success = false;
                result.Errors.Add("No file data provided.");
                return result;
            }

            try
            {
                using var reader = new StreamReader(fileStream);
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    result.ProcessedCount++;
                    var parts = line.Split(',');
                    if (parts.Length < 2)
                    {
                        result.ErrorCount++;
                        result.Errors.Add($"Invalid line format at row {result.ProcessedCount}: {line}");
                        continue;
                    }

                    var barcode = parts[0].Trim();
                    var classCode = parts[1].Trim();

                    var borrower = await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorBarNo == barcode);
                    if (borrower == null)
                    {
                        result.ErrorCount++;
                        result.Errors.Add($"Borrower not found for barcode: {barcode}");
                        continue;
                    }

                    borrower.BorClass = classCode;
                    borrower.BorDatetime = DateTime.Now;
                    result.SuccessCount++;
                }

                await _delib.SaveChangesAsync();
                result.Message = $"Successfully updated {result.SuccessCount} user classes.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add($"System error: {ex.Message}");
            }

            return result;
        }
    }
}