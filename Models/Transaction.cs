using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Transaction
    {
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please enter Transaction Amount")]
        [Display(Name = "Transaction Fee")]
        public decimal Transaction_Fee { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Transaction Date")]
        [Display(Name = "Transaction Date")]
        public DateTime Transaction_Date { get; set; }

        [Required]
        [Display(Name = "Player ID")]
        public int? PlayerId { get; set; }

        public virtual Player? Players { get; set; }
    }
}
