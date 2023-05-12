


namespace WinFormsApp1
{

    public class HumanResources_Department
    {
        public short DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; }

        public HumanResources_Department()
        {
            ModifiedDate = System.DateTime.Now;
            HumanResources_EmployeeDepartmentHistory = new System.Collections.Generic.List<HumanResources_EmployeeDepartmentHistory>();
        }
    }

}
