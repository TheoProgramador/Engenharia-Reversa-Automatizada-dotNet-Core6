


namespace WinFormsApp1
{

    public class Sales_ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
