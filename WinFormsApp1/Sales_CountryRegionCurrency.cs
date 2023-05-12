


namespace WinFormsApp1
{

    public class Sales_CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_CountryRegion Person_CountryRegion { get; set; }

        public virtual Sales_Currency Sales_Currency { get; set; }

        public Sales_CountryRegionCurrency()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
