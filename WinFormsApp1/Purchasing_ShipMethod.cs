


namespace WinFormsApp1
{

    public class Purchasing_ShipMethod
    {
        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }

        public Purchasing_ShipMethod()
        {
            ShipBase = 0.00m;
            ShipRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Purchasing_PurchaseOrderHeader = new System.Collections.Generic.List<Purchasing_PurchaseOrderHeader>();
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
