


namespace WinFormsApp1
{

    public class Sales_Currency
    {
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_CurrencyRate> Sales_CurrencyRate_FromCurrencyCode { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_CurrencyRate> Sales_CurrencyRate_ToCurrencyCode { get; set; }

        public Sales_Currency()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrency = new System.Collections.Generic.List<Sales_CountryRegionCurrency>();
            Sales_CurrencyRate_FromCurrencyCode = new System.Collections.Generic.List<Sales_CurrencyRate>();
            Sales_CurrencyRate_ToCurrencyCode = new System.Collections.Generic.List<Sales_CurrencyRate>();
        }
    }

}
