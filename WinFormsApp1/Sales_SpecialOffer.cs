


namespace WinFormsApp1
{

    public class Sales_SpecialOffer
    {
        public int SpecialOfferId { get; set; }
        public string Description { get; set; }
        public decimal DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int MinQty { get; set; }
        public int? MaxQty { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; }

        public Sales_SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_SpecialOfferProduct = new System.Collections.Generic.List<Sales_SpecialOfferProduct>();
        }
    }

}
