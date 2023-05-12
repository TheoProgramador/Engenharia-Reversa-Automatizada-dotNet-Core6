


namespace WinFormsApp1
{

    public class Sales_Store
    {
        public int BusinessEntityId { get; set; }
        public string Name { get; set; }
        public int? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customer { get; set; }


        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; }

        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; }

        public Sales_Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customer = new System.Collections.Generic.List<Sales_Customer>();
        }
    }

}
