


namespace WinFormsApp1
{

    public class Production_Illustration
    {
        public int IllustrationId { get; set; }
        public string Diagram { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductModelIllustration> Production_ProductModelIllustration { get; set; }

        public Production_Illustration()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductModelIllustration = new System.Collections.Generic.List<Production_ProductModelIllustration>();
        }
    }

}
