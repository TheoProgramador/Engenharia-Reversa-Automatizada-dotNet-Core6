


namespace WinFormsApp1
{

    public class Person_Password
    {
        public int BusinessEntityId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_Person Person_Person { get; set; }

        public Person_Password()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
