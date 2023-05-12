


namespace WinFormsApp1
{

    public class Sales_CreditCard
    {
        public int CreditCardId { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public byte ExpMonth { get; set; }
        public short ExpYear { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Sales_PersonCreditCard> Sales_PersonCreditCard { get; set; }
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeader { get; set; }

        public Sales_CreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_PersonCreditCard = new System.Collections.Generic.List<Sales_PersonCreditCard>();
            Sales_SalesOrderHeader = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
        }
    }

}
