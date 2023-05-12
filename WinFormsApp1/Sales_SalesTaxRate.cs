


namespace WinFormsApp1
{

    public class Sales_SalesTaxRate
    {
        public int SalesTaxRateId { get; set; }
        public int StateProvinceId { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Person_StateProvince Person_StateProvince { get; set; }

        public Sales_SalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
