


namespace WinFormsApp1
{

    public class Person_PersonPhone
    {
        public int BusinessEntityId { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_Person Person_Person { get; set; }

        public virtual Person_PhoneNumberType Person_PhoneNumberType { get; set; }

        public Person_PersonPhone()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
