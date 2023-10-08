namespace RSFC_web.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }

        public decimal Transaction_Fee { get; set; }

        public DateTime Transaction_Date { get; set; }

        public int? PlayerId { get; set; }

        public virtual Player? Players { get; set; }
    }
}
