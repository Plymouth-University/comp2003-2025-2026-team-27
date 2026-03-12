using Lms.Data.Models.Delib;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class BorrowerFileListViewModel
    {
        public List<FileSetName> FileSets { get; set; } = new();
        public FileSetName SelectedFileSet { get; set; } = new();
        
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int PageSize { get; set; } = 8;

        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        
        public string? OperatorName { get; set; }
    }
}
