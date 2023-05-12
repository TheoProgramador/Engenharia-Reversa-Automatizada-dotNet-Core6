


namespace WinFormsApp1
{

    public class UspGetBillOfMaterialsReturnModel
    {
        public System.Int32? ProductAssemblyID { get; set; }
        public System.Int32? ComponentID { get; set; }
        public System.String ComponentDesc { get; set; }
        public System.Decimal? TotalQuantity { get; set; }
        public System.Decimal? StandardCost { get; set; }
        public System.Decimal? ListPrice { get; set; }
        public System.Int16? BOMLevel { get; set; }
        public System.Int32? RecursionLevel { get; set; }
    }

}
