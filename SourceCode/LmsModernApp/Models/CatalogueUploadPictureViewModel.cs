namespace LmsModernApp.ViewModels
{
    public class CatalogueUploadPictureViewModel
    {
        public int? CatNo { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? LibGroup { get; set; }
        public string? ReturnUrl { get; set; }
        public bool HasPicture { get; set; }
        public string? PicFilename { get; set; }
    }
}
