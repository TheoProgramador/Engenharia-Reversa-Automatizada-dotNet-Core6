


namespace WinFormsApp1
{

    public class Person_EmailAddress
    {
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
        public string EmailAddress { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_Person Person_Person { get; set; }

        public Person_EmailAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
