


namespace WinFormsApp1
{

    public class Production_ProductReview
    {
        public int ProductReviewId { get; set; }
        public int ProductId { get; set; }
        public string ReviewerName { get; set; }
        public System.DateTime ReviewDate { get; set; }
        public string EmailAddress { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Product Production_Product { get; set; }

        public Production_ProductReview()
        {
            ReviewDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

}
