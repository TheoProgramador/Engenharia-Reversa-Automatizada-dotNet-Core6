


namespace WinFormsApp1
{

    public class Person_ContactType
    {
        public int ContactTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; }

        public Person_ContactType()
        {
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContact = new System.Collections.Generic.List<Person_BusinessEntityContact>();
        }
    }

}
