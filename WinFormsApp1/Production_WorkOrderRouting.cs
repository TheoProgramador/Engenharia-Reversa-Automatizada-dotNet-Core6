


namespace WinFormsApp1
{

    public class Production_WorkOrderRouting
    {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public short OperationSequence { get; set; }
        public short LocationId { get; set; }
        public System.DateTime ScheduledStartDate { get; set; }
        public System.DateTime ScheduledEndDate { get; set; }
        public System.DateTime? ActualStartDate { get; set; }
        public System.DateTime? ActualEndDate { get; set; }
        public decimal? ActualResourceHrs { get; set; }
        public decimal PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Location Production_Location { get; set; }

        public virtual Production_WorkOrder Production_WorkOrder { get; set; }

        public Production_WorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
