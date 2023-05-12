


namespace WinFormsApp1
{

    public class Sales_SalesReason
    {
        public int SalesReasonId { get; set; }
        public string Name { get; set; }
        public string ReasonType { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; }

        public Sales_SalesReason()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeaderSalesReason = new System.Collections.Generic.List<Sales_SalesOrderHeaderSalesReason>();
        }
    }

}
