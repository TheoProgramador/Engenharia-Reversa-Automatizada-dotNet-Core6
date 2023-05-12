


namespace WinFormsApp1
{

    public class Person_CountryRegion
    {
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_StateProvince> Person_StateProvince { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritory> Sales_SalesTerritory { get; set; }

        public Person_CountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrency = new System.Collections.Generic.List<Sales_CountryRegionCurrency>();
            Sales_SalesTerritory = new System.Collections.Generic.List<Sales_SalesTerritory>();
            Person_StateProvince = new System.Collections.Generic.List<Person_StateProvince>();
        }
    }

}
