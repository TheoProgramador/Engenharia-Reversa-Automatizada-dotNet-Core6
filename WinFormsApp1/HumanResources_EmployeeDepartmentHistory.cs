


namespace WinFormsApp1
{

    public class HumanResources_EmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; }
        public short DepartmentId { get; set; }
        public byte ShiftId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual HumanResources_Department HumanResources_Department { get; set; }

        public virtual HumanResources_Employee HumanResources_Employee { get; set; }

        public virtual HumanResources_Shift HumanResources_Shift { get; set; }

        public HumanResources_EmployeeDepartmentHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
