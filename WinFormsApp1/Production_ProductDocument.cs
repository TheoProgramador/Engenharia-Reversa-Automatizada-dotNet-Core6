


namespace WinFormsApp1
{

    public class Production_ProductDocument
    {
        public int ProductId { get; set; }
        public System.Data.Entity.Hierarchy.HierarchyId DocumentNode { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Document Production_Document { get; set; }

        public virtual Production_Product Production_Product { get; set; }

        public Production_ProductDocument()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
