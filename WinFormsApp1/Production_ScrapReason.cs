


namespace WinFormsApp1
{

    public class Production_ScrapReason
    {
        public short ScrapReasonId { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_WorkOrder> Production_WorkOrder { get; set; }

        public Production_ScrapReason()
        {
            ModifiedDate = System.DateTime.Now;
            Production_WorkOrder = new System.Collections.Generic.List<Production_WorkOrder>();
        }
    }

}
