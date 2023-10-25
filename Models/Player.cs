using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Player"
    public partial class Player
    {
        // This property represents the Player's unique identifier.
        [Required]
        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }

        // This property represents the Player's full name.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name"), MaxLength(50)]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid fullname starting with capital letters.")]
        [Display(Name = "Full Name")]
        public string Player_Name { get; set; } = null!;

        // This property represents the Player's gender.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Gender"), MaxLength(6)] // Limits the gender to a maximum of 6 characters.
        [RegularExpression(@"^(Male|Female|Other)$", ErrorMessage = "Please enter a valid gender.")] // Validates that the gender follows the specific format and provides a error message if not.
        [Display(Name = "Gender")]
        public string? Player_Gender { get; set; }

        // This property represents the Player's date of birth.
        [DataType(DataType.Date)] // Specifies that it contains a date.
        [Required(ErrorMessage = "Please Enter valid Date of Birth")] // Ensures that the date of birth is mandatory and provides a error message if not provided.
        [Display(Name = "Date of Birth")]
        public DateTime? Player_Dob { get; set; }

        // This property represents the Player's phone number.
        [DataType(DataType.PhoneNumber), MaxLength(17)]
        [RegularExpression(@"^\(\+64\) \d{2}-\d{3}-\d{4}$", ErrorMessage = "Phone Number is not valid. Accepted format (+64) 12-345-6789 for example.")]
        [Display(Name = "Phone Number")]
        public string? Player_Phone_Number { get; set; }

        // This property represents the Player's email address.
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string? Player_Email { get; set; }

        // These properties represent IDs for Coach, Team, and Position entities.
        [Required]
        [Display(Name = "Coach")]
        public int? CoachId { get; set; } // Allows null values.

        [Required]
        [Display(Name = "Team")]
        public int? TeamId { get; set; } // Allows null values.

        [Required]
        [Display(Name = "Position")]
        public int? PositionId { get; set; } // Allows null values.

        // These properties represent associations with Coach, Position, and Team entities.
        public virtual Coach? Coaches { get; set; } = null!;
        public virtual Position? Positions { get; set; } = null!;
        public virtual Team? Teams { get; set; } = null!;

        // This property represents a collection of associated transactions and initializes it as an empty list.
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
