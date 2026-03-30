namespace LmsModernApp.Models
{
    public class ReadingListItem
    {
        public string BorrowerBarcode { get; set; } = string.Empty;
        public string ListName { get; set; } = string.Empty;
        public int CatNo { get; set; }
        public long? Priority { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Publication { get; set; } = string.Empty;
    }
}