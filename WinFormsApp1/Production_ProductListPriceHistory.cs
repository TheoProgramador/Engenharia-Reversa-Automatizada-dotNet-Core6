


namespace WinFormsApp1
{

    public class Production_ProductListPriceHistory
    {
        public int ProductId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public decimal ListPrice { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public Production_ProductListPriceHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
