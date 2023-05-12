


namespace WinFormsApp1
{

    public class Sales_Customer
    {
        public int CustomerId { get; set; }
        public int? PersonId { get; set; }
        public int? StoreId { get; set; }
        public int? TerritoryId { get; set; }
        public string AccountNumber { get; private set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }


        public virtual Person_Person Person_Person { get; set; }

        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; }

        public virtual Sales_Store Sales_Store { get; set; }

        public Sales_Customer()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
