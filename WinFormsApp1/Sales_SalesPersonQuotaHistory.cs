


namespace WinFormsApp1
{

    public class Sales_SalesPersonQuotaHistory
    {
        public int BusinessEntityId { get; set; }
        public System.DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; }

        public Sales_SalesPersonQuotaHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
