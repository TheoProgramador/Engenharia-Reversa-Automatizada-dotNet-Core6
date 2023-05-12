


namespace WinFormsApp1
{

    public class Production_BillOfMaterials
    {
        public int BillOfMaterialsId { get; set; }
        public int? ProductAssemblyId { get; set; }
        public int ComponentId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string UnitMeasureCode { get; set; }
        public short BomLevel { get; set; }
        public decimal PerAssemblyQty { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Component { get; set; }

        public virtual Production_Product ProductAssembly { get; set; }

        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; }

        public Production_BillOfMaterials()
        {
            StartDate = System.DateTime.Now;
            PerAssemblyQty = 1.00m;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
