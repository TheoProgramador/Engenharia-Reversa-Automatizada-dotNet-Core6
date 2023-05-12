


namespace WinFormsApp1
{

    public class Production_Location
    {
        public short LocationId { get; set; }
        public string Name { get; set; }
        public decimal CostRate { get; set; }
        public decimal Availability { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductInventory> Production_ProductInventory { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; }

        public Production_Location()
        {
            CostRate = 0.00m;
            Availability = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Production_ProductInventory = new System.Collections.Generic.List<Production_ProductInventory>();
            Production_WorkOrderRouting = new System.Collections.Generic.List<Production_WorkOrderRouting>();
        }
    }

}
