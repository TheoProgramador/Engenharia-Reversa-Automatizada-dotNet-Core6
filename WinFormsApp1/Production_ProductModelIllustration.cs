


namespace WinFormsApp1
{

    public class Production_ProductModelIllustration
    {
        public int ProductModelId { get; set; }
        public int IllustrationId { get; set; }
        public System.DateTime ModifiedDate { get; set; }


        public virtual Production_Illustration Production_Illustration { get; set; }

        public virtual Production_ProductModel Production_ProductModel { get; set; }

        public Production_ProductModelIllustration()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
