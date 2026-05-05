using Lms.Data.Models.Delib;
using Lms.Data.Models.Delocal;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Lms.Data
{
    public interface IBorrowerImportService
    {
        // Template Import
        Task<List<ImportBorTemplate>> GetAvailableTemplatesAsync();
        Task<ImportResult> ProcessImportTemplateAsync(int templateId, Stream fileStream);

        // Pictures Import
        Task<ImportResult> ProcessImportPicturesAsync(Stream zipStream);

        // Group Import
        Task<ImportResult> ProcessImportGroupAsync(Stream fileStream);

        // Class Import
        Task<ImportResult> ProcessImportClassAsync(Stream fileStream);
    }

    public class ImportResult
    {
        public bool Success { get; set; }
        public int ProcessedCount { get; set; }
        public int SuccessCount { get; set; }
        public int ErrorCount { get; set; }
        public List<string> Errors { get; set; } = new();
        public string Message { get; set; } = "";
    }
}