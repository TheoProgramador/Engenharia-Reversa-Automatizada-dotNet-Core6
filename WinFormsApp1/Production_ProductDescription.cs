


namespace WinFormsApp1
{

    public class Production_ProductDescription
    {
        public int ProductDescriptionId { get; set; }
        public string Description { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; }

        public Production_ProductDescription()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_ProductModelProductDescriptionCulture = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>();
        }
    }

}
