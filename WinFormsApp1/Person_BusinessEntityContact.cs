


namespace WinFormsApp1
{

    public class Person_BusinessEntityContact
    {
        public int BusinessEntityId { get; set; }
        public int PersonId { get; set; }
        public int ContactTypeId { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; }

        public virtual Person_ContactType Person_ContactType { get; set; }

        public virtual Person_Person Person_Person { get; set; }

        public Person_BusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
