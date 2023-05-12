


namespace WinFormsApp1
{

    public class Production_ProductPhoto
    {
        public int ProductPhotoId { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; }

        public Production_ProductPhoto()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductProductPhoto = new System.Collections.Generic.List<Production_ProductProductPhoto>();
        }
    }

}
