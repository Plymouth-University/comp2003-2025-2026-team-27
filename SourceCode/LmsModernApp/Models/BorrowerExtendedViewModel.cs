using Lms.Data.Models.Delib;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class BorrowerExtendedViewModel
    {
        public Lms.Data.Models.Delib.Borrower Borrower { get; set; } = new();
        
        // History View Data
        public List<BorHistory> History { get; set; } = new();
        public List<StkItem> OnLoan { get; set; } = new();
        public List<StkHistory> ReturnHistory { get; set; } = new();
        public List<Reservation> Reservations { get; set; } = new();
        
        // Memos View Data
        public List<BorMemo> Memos { get; set; } = new();
        public BorMemo SelectedMemo { get; set; } = new();
        public List<Lms.Data.LookupItem> MemoTypes { get; set; } = new();
        
        // Survey Data
        public List<Survey> AvailableSurveys { get; set; } = new();
        public BorSurvey? CurrentBorSurvey { get; set; }
        
        // ILR Data
        public IlrField? IlrData { get; set; }
        public IlrAdditionalField? IlrAdditionalData { get; set; }

        // Finance Data
        public List<FinTran> FinanceTransactions { get; set; } = new();

        // Course Data
        public List<BorCoursePeriod> CoursePeriods { get; set; } = new();
    }
}
