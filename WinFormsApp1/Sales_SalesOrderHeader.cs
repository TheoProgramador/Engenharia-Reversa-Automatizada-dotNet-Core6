


namespace WinFormsApp1
{

    public class Sales_SalesOrderHeader
    {
        public int SalesOrderId { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime? ShipDate { get; set; }
        public byte Status { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; private set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? TerritoryId { get; set; }
        public int BillToAddressId { get; set; }
        public int ShipToAddressId { get; set; }
        public int ShipMethodId { get; set; }
        public int? CreditCardId { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public int? CurrencyRateId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; private set; }
        public string Comment { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; }


        public virtual Person_Address BillToAddress { get; set; }

        public virtual Person_Address ShipToAddress { get; set; }

        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; }

        public virtual Sales_CreditCard Sales_CreditCard { get; set; }

        public virtual Sales_CurrencyRate Sales_CurrencyRate { get; set; }

        public virtual Sales_Customer Sales_Customer { get; set; }

        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; }

        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; }

        public Sales_SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderDetail = new System.Collections.Generic.List<Sales_SalesOrderDetail>();
            Sales_SalesOrderHeaderSalesReason = new System.Collections.Generic.List<Sales_SalesOrderHeaderSalesReason>();
        }
    }

}
