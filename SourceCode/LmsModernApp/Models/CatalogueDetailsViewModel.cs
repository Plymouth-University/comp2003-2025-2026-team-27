namespace LmsModernApp.ViewModels
{
    public class CatalogueDetailsViewModel
    {
        public int? CatNo { get; set; }
        public string? Author { get; set; }   // CatStr1
        public string? Title { get; set; }   // CatStr2
        public string? Publisher { get; set; }   // CatStr3
        public string? CallNumber { get; set; }   // CatStr4
        public string? LibGroup { get; set; }   // CatLibGroup
        public string? TemplateId { get; set; }
        public string? CatRestrict { get; set; }
        public decimal? CatSecurity { get; set; }
        public string? CreatedBy { get; set; }   // CatCreateOper
        public DateTime? CreatedDate { get; set; }   // CatCreateDatetime
        public string? LastModifiedBy { get; set; }   // CatOper
        public DateTime? LastModifiedDate { get; set; }   // CatDatetime
    }
}
