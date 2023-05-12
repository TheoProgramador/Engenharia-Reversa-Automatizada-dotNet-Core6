


namespace WinFormsApp1
{

    public class HumanResources_Shift
    {
        public byte ShiftId { get; set; }
        public string Name { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; }

        public HumanResources_Shift()
        {
            ModifiedDate = System.DateTime.Now;
            HumanResources_EmployeeDepartmentHistory = new System.Collections.Generic.List<HumanResources_EmployeeDepartmentHistory>();
        }
    }

}
