


namespace WinFormsApp1
{

    public class HumanResources_Employee
    {
        public int BusinessEntityId { get; set; }
        public string NationalIdNumber { get; set; }
        public string LoginId { get; set; }
        public System.Data.Entity.Hierarchy.HierarchyId OrganizationNode { get; set; }
        public short? OrganizationLevel { get; private set; }
        public string JobTitle { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public System.DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; }
        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; }
        public virtual System.Collections.Generic.ICollection<HumanResources_JobCandidate> HumanResources_JobCandidate { get; set; }
        public virtual System.Collections.Generic.ICollection<Production_Document> Production_Document { get; set; }
        public virtual System.Collections.Generic.ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; }


        public virtual Person_Person Person_Person { get; set; }

        public HumanResources_Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Document = new System.Collections.Generic.List<Production_Document>();
            HumanResources_EmployeeDepartmentHistory = new System.Collections.Generic.List<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistory = new System.Collections.Generic.List<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidate = new System.Collections.Generic.List<HumanResources_JobCandidate>();
            Purchasing_PurchaseOrderHeader = new System.Collections.Generic.List<Purchasing_PurchaseOrderHeader>();
        }
    }

}
