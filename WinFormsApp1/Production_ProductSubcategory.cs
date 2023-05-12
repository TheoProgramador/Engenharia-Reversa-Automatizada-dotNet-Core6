


namespace WinFormsApp1
{

    public class Production_ProductSubcategory
    {
        public int ProductSubcategoryId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Product { get; set; }


        public virtual Production_ProductCategory Production_ProductCategory { get; set; }

        public Production_ProductSubcategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Product = new System.Collections.Generic.List<Production_Product>();
        }
    }

}
