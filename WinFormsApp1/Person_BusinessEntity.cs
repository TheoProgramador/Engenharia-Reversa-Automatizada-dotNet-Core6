


namespace WinFormsApp1
{

    public class Person_BusinessEntity
    {
        public int BusinessEntityId { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Person_Person Person_Person { get; set; }
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; }
        public virtual Sales_Store Sales_Store { get; set; }
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; }
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; }

        public Person_BusinessEntity()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddress = new System.Collections.Generic.List<Person_BusinessEntityAddress>();
            Person_BusinessEntityContact = new System.Collections.Generic.List<Person_BusinessEntityContact>();
        }
    }

}
