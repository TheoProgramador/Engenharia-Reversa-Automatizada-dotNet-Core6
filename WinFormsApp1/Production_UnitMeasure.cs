


namespace WinFormsApp1
{

    public class Production_UnitMeasure
    {
        public string UnitMeasureCode { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_BillOfMaterials> Production_BillOfMaterials { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Product_SizeUnitMeasureCode { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Product_WeightUnitMeasureCode { get; set; }
        public virtual System.Collections.Generic.ICollection<Purchasing_ProductVendor> Purchasing_ProductVendor { get; set; }

        public Production_UnitMeasure()
        {
            ModifiedDate = System.DateTime.Now;
            Production_BillOfMaterials = new System.Collections.Generic.List<Production_BillOfMaterials>();
            Production_Product_SizeUnitMeasureCode = new System.Collections.Generic.List<Production_Product>();
            Production_Product_WeightUnitMeasureCode = new System.Collections.Generic.List<Production_Product>();
            Purchasing_ProductVendor = new System.Collections.Generic.List<Purchasing_ProductVendor>();
        }
    }

}
