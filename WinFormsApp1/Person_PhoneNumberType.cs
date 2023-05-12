


namespace WinFormsApp1
{

    public class Person_PhoneNumberType
    {
        public int PhoneNumberTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_PersonPhone> Person_PersonPhone { get; set; }

        public Person_PhoneNumberType()
        {
            ModifiedDate = System.DateTime.Now;
            Person_PersonPhone = new System.Collections.Generic.List<Person_PersonPhone>();
        }
    }

}
