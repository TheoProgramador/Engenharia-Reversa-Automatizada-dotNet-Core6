


namespace WinFormsApp1
{

    public class Person_Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Comentarios { get; set; }

        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddress { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader_BillToAddressId { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader_ShipToAddressId { get; set; }


        public virtual Person_StateProvince Person_StateProvince { get; set; }

        public Person_Address()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddress = new System.Collections.Generic.List<Person_BusinessEntityAddress>();
            Sales_SalesOrderHeader_BillToAddressId = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeader_ShipToAddressId = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
