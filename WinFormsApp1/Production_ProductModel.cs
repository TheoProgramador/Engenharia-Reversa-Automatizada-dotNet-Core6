


namespace WinFormsApp1
{

    public class Production_ProductModel
    {
        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public string Instructions { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Product { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; }

        public Production_ProductModel()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Product = new System.Collections.Generic.List<Production_Product>();
            Production_ProductModelIllustration = new System.Collections.Generic.List<Production_ProductModelIllustration>();
            Production_ProductModelProductDescriptionCulture = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>();
        }
    }

}
