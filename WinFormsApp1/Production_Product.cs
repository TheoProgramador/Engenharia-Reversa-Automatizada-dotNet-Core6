


namespace WinFormsApp1
{

    public class Production_Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryId { get; set; }
        public int? ProductModelId { get; set; }
        public System.DateTime SellStartDate { get; set; }
        public System.DateTime? SellEndDate { get; set; }
        public System.DateTime? DiscontinuedDate { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterials> Production_BillOfMaterials_ComponentId { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterials> Production_BillOfMaterials_ProductAssemblyId { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductCostHistory> Production_ProductCostHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductDocument> Production_ProductDocument { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductInventory> Production_ProductInventory { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductProductPhoto> Production_ProductProductPhoto { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_ProductReview> Production_ProductReview { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_TransactionHistory> Production_TransactionHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_WorkOrder> Production_WorkOrder { get; set; }
        public virtual System.Collections.Generic.ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; }
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItem { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; }


        public virtual Production_ProductModel Production_ProductModel { get; set; }

        public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; }

        public virtual Production_UnitMeasure Production_UnitMeasure_SizeUnitMeasureCode { get; set; }

        public virtual Production_UnitMeasure Production_UnitMeasure_WeightUnitMeasureCode { get; set; }

        public Production_Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_BillOfMaterials_ProductAssemblyId = new System.Collections.Generic.List<Production_BillOfMaterials>();
            Production_BillOfMaterials_ComponentId = new System.Collections.Generic.List<Production_BillOfMaterials>();
            Production_ProductCostHistory = new System.Collections.Generic.List<Production_ProductCostHistory>();
            Production_ProductDocument = new System.Collections.Generic.List<Production_ProductDocument>();
            Production_ProductInventory = new System.Collections.Generic.List<Production_ProductInventory>();
            Production_ProductListPriceHistory = new System.Collections.Generic.List<Production_ProductListPriceHistory>();
            Production_ProductProductPhoto = new System.Collections.Generic.List<Production_ProductProductPhoto>();
            Production_ProductReview = new System.Collections.Generic.List<Production_ProductReview>();
            Purchasing_ProductVendor = new System.Collections.Generic.List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetail = new System.Collections.Generic.List<Purchasing_PurchaseOrderDetail>();
            Sales_ShoppingCartItem = new System.Collections.Generic.List<Sales_ShoppingCartItem>();
            Sales_SpecialOfferProduct = new System.Collections.Generic.List<Sales_SpecialOfferProduct>();
            Production_TransactionHistory = new System.Collections.Generic.List<Production_TransactionHistory>();
            Production_WorkOrder = new System.Collections.Generic.List<Production_WorkOrder>();
        }
    }

}
