


namespace WinFormsApp1
{

    public class Production_WorkOrder
    {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderQty { get; set; }
        public int StockedQty { get; private set; }
        public short ScrappedQty { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public short? ScrapReasonId { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_WorkOrderRouting> Production_WorkOrderRouting { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public virtual Production_ScrapReason Production_ScrapReason { get; set; }

        public Production_WorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            Production_WorkOrderRouting = new System.Collections.Generic.List<Production_WorkOrderRouting>();
        }
    }

}
