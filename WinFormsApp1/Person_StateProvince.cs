


namespace WinFormsApp1
{

    public class Person_StateProvince
    {
        public int StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public bool IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int TerritoryId { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_Address> Person_Address { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesTaxRate> Sales_SalesTaxRate { get; set; }


        public virtual Person_CountryRegion Person_CountryRegion { get; set; }

        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; }

        public Person_StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_Address = new System.Collections.Generic.List<Person_Address>();
            Sales_SalesTaxRate = new System.Collections.Generic.List<Sales_SalesTaxRate>();
        }
    }

}
