


namespace WinFormsApp1
{

    public class Production_ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductSubcategory> Production_ProductSubcategory { get; set; }

        public Production_ProductCategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_ProductSubcategory = new System.Collections.Generic.List<Production_ProductSubcategory>();
        }
    }

}
