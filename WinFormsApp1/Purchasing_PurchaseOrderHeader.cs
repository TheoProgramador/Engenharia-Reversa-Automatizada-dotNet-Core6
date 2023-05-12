


namespace WinFormsApp1
{

    public class Purchasing_PurchaseOrderHeader
    {
        public int PurchaseOrderId { get; set; }
        public byte RevisionNumber { get; set; }
        public byte Status { get; set; }
        public int EmployeeId { get; set; }
        public int VendorId { get; set; }
        public int ShipMethodId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime? ShipDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; private set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; }


        public virtual HumanResources_Employee HumanResources_Employee { get; set; }

        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; }

        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; }

        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Purchasing_PurchaseOrderDetail = new System.Collections.Generic.List<Purchasing_PurchaseOrderDetail>();
        }
    }

}
