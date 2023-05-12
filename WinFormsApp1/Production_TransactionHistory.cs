


namespace WinFormsApp1
{

    public class Production_TransactionHistory
    {
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int ReferenceOrderId { get; set; }
        public int ReferenceOrderLineId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public decimal ActualCost { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public Production_TransactionHistory()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
