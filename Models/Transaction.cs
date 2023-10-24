using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Transaction"
    public partial class Transaction
    {
        // Define a required integer property for the transaction's ID with a display name.
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }

        // Define a decimal property for the transaction's fee with data type and validation rules.
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please enter Transaction Amount")]
        [RegularExpression(@"^\$?\d+(\.\d{2})?$", ErrorMessage = "Please enter a valid amount.")]
        [Display(Name = "Transaction Fee")]
        public decimal Transaction_Fee { get; set; }

        // Define a property for the transaction's date with data type and required validation.
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Transaction Date")]
        [Display(Name = "Transaction Date")]
        public DateTime Transaction_Date { get; set; }

        // Define a required integer property for the associated player with a display name. It allows null values.
        [Required]
        [Display(Name = "Player")]
        public int? PlayerId { get; set; }

        // Define a virtual navigation property for the associated player entity. It allows null values.
        public virtual Player? Players { get; set; }
    }
}
