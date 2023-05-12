


namespace WinFormsApp1
{

    public class Purchasing_Vendor
    {
        public int BusinessEntityId { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public byte CreditRating { get; set; }
        public bool PreferredVendorStatus { get; set; }
        public bool ActiveFlag { get; set; }
        public string PurchasingWebServiceUrl { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; }
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; }


        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; }

        public Purchasing_Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = System.DateTime.Now;
            Purchasing_ProductVendor = new System.Collections.Generic.List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderHeader = new System.Collections.Generic.List<Purchasing_PurchaseOrderHeader>();
        }
    }

}
