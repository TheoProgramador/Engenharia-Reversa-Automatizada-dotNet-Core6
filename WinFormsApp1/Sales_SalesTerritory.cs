


namespace WinFormsApp1
{

    public class Sales_SalesTerritory
    {
        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYtd { get; set; }
        public decimal CostLastYear { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_StateProvince> Person_StateProvince { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customer { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesPerson> Sales_SalesPerson { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; }


        public virtual Person_CountryRegion Person_CountryRegion { get; set; }

        public Sales_SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customer = new System.Collections.Generic.List<Sales_Customer>();
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesPerson = new System.Collections.Generic.List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistory = new System.Collections.Generic.List<Sales_SalesTerritoryHistory>();
            Person_StateProvince = new System.Collections.Generic.List<Person_StateProvince>();
        }
    }

}
