


namespace WinFormsApp1
{

    public class Production_ProductProductPhoto
    {
        public int ProductId { get; set; }
        public int ProductPhotoId { get; set; }
        public bool Primary { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public virtual Production_ProductPhoto Production_ProductPhoto { get; set; }

        public Production_ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
