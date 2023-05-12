


namespace WinFormsApp1
{

    public class Sales_CurrencyRate
    {
        public int CurrencyRateId { get; set; }
        public System.DateTime CurrencyRateDate { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public decimal AverageRate { get; set; }
        public decimal EndOfDayRate { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }


        public virtual Sales_Currency Sales_Currency_FromCurrencyCode { get; set; }

        public virtual Sales_Currency Sales_Currency_ToCurrencyCode { get; set; }

        public Sales_CurrencyRate()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
