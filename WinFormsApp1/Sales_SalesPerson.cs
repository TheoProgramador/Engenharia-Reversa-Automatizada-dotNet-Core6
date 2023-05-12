


namespace WinFormsApp1
{

    public class Sales_SalesPerson
    {
        public int BusinessEntityId { get; set; }
        public int? TerritoryId { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_Store> Sales_Store { get; set; }


        public virtual HumanResources_Employee HumanResources_Employee { get; set; }

        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; }

        public Sales_SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesPersonQuotaHistory = new System.Collections.Generic.List<Sales_SalesPersonQuotaHistory>();
            Sales_SalesTerritoryHistory = new System.Collections.Generic.List<Sales_SalesTerritoryHistory>();
            Sales_Store = new System.Collections.Generic.List<Sales_Store>();
        }
    }

}
