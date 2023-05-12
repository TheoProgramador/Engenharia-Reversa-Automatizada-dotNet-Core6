


namespace WinFormsApp1
{

    public class Person_Person
    {
        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual HumanResources_Employee HumanResources_Employee { get; set; }
        public virtual Person_Password Person_Password { get; set; }
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContact { get; set; }
        public virtual System.Collections.Generic.ICollection<Person_EmailAddress> Person_EmailAddress { get; set; }
        public virtual System.Collections.Generic.ICollection<Person_PersonPhone> Person_PersonPhone { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customer { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; }


        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; }

        public Person_Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContact = new System.Collections.Generic.List<Person_BusinessEntityContact>();
            Sales_Customer = new System.Collections.Generic.List<Sales_Customer>();
            Person_EmailAddress = new System.Collections.Generic.List<Person_EmailAddress>();
            Sales_PersonCreditCard = new System.Collections.Generic.List<Sales_PersonCreditCard>();
            Person_PersonPhone = new System.Collections.Generic.List<Person_PersonPhone>();
        }
    }

}
