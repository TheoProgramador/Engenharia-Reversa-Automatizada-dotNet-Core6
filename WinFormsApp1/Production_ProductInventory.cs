


namespace WinFormsApp1
{

    public class Production_ProductInventory
    {
        public int ProductId { get; set; }
        public short LocationId { get; set; }
        public string Shelf { get; set; }
        public byte Bin { get; set; }
        public short Quantity { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Location Production_Location { get; set; }

        public virtual Production_Product Production_Product { get; set; }

        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
