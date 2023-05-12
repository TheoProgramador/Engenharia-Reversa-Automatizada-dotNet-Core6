


namespace WinFormsApp1
{

    public class HumanResources_EmployeePayHistory
    {
        public int BusinessEntityId { get; set; }
        public System.DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual HumanResources_Employee HumanResources_Employee { get; set; }

        public HumanResources_EmployeePayHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
