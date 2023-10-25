using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Transaction"
    public partial class Transaction
    {
        // This property represents the Transaction's unique identifier.
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }

        // This property represents the Transaction's fee.
        [DataType(DataType.Currency)] // Specifies that it contains currency data.
        [Required(ErrorMessage = "Please enter Transaction Amount")]
        [RegularExpression(@"^\$?\d+(\.\d{2})?$", ErrorMessage = "Please enter a valid amount.")] // Validates that the fee follows the specific format and provides a error message if not.
        [Display(Name = "Transaction Fee")]
        public decimal Transaction_Fee { get; set; }

        // This property represents the Transaction's date.
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Transaction Date")]
        [Display(Name = "Transaction Date")]
        public DateTime Transaction_Date { get; set; }

        // This property represents the associated Player.
        [Required]
        [Display(Name = "Player")]
        public int? PlayerId { get; set; }

        // This property represents a virtual navigation property for the associated Player entity.
        public virtual Player? Players { get; set; }
    }
}
