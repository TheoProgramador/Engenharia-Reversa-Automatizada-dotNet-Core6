


namespace WinFormsApp1
{

    public class Sales_SalesTerritoryHistory
    {
        public int BusinessEntityId { get; set; }
        public int TerritoryId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; }

        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; }

        public Sales_SalesTerritoryHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
