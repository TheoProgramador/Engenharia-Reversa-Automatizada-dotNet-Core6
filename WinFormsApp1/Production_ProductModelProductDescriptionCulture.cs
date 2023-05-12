


namespace WinFormsApp1
{

    public class Production_ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string CultureId { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Culture Production_Culture { get; set; }

        public virtual Production_ProductDescription Production_ProductDescription { get; set; }

        public virtual Production_ProductModel Production_ProductModel { get; set; }

        public Production_ProductModelProductDescriptionCulture()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
