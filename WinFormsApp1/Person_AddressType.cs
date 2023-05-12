


namespace WinFormsApp1
{

    public class Person_AddressType
    {
        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; }

        public Person_AddressType()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddress = new System.Collections.Generic.List<Person_BusinessEntityAddress>();
        }
    }

}
