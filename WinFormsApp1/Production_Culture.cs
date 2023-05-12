


namespace WinFormsApp1
{

    public class Production_Culture
    {
        public string CultureId { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; }

        public Production_Culture()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductModelProductDescriptionCulture = new System.Collections.Generic.List<Production_ProductModelProductDescriptionCulture>();
        }
    }

}
