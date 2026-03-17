using Lms.Data;
using Lms.Data.Models.Delib;
using Lms.Data.Models.Decat;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class BorrowerFileListViewModel
    {
        // Dropdown & Filter
        public string SelectedOperator { get; set; } = string.Empty;
        public List<LookupItem> Operators { get; set; } = new();

        // Main File List (Borrower Files)
        public List<FileSetName> FileSets { get; set; } = new();
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public string SortBy { get; set; } = "FileDesc";
        public string SortOrder { get; set; } = "ASC";
        public string? SearchTerm { get; set; }

        // Edit Section (Borrower File)
        public FileSetName SelectedFileSet { get; set; } = new();
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }

        // General Reading List Section (Catalog Files)
        public List<FileCatName> GeneralReadingLists { get; set; } = new();
        public List<AFileSetLibCat> RelatedReadingListLinks { get; set; } = new();
    }
}
