


namespace WinFormsApp1
{

    public class Sales_SpecialOfferProduct
    {
        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetail { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public virtual Sales_SpecialOffer Sales_SpecialOffer { get; set; }

        public Sales_SpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SalesOrderDetail = new System.Collections.Generic.List<Sales_SalesOrderDetail>();
        }
    }

}
