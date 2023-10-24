using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Player"
    public partial class Player
    {
        // Define a required integer property for the player's ID with a display name.
        [Required]
        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }

        // Define a string property for the player's full name with data type and validation rules.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid fullname starting with capital letters.")]
        [Display(Name = "Full Name")]
        public string Player_Name { get; set; } = null!;

        // Define a string property for the player's gender with data type, length validation, and format validation. It allows null values.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Gender")]
        [MaxLength(6)]
        [RegularExpression(@"^(Male|Female|Other)$", ErrorMessage = "Please enter a valid gender.")]
        [Display(Name = "Gender")]
        public string? Player_Gender { get; set; }

        // Define a property for the player's date of birth with data type and required validation.
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter valid Date of Birth")]
        [Display(Name = "Date of Birth")]
        public DateTime? Player_Dob { get; set; }

        // Define a property for the player's phone number with phone number format validation. It allows null values.
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(\+64\) \d{2}-\d{3}-\d{4}$", ErrorMessage = "Phone Number is not valid. Accepted format (+64) 12-345-6789 for example.")]
        [Display(Name = "Phone Number")]
        public string? Player_Phone_Number { get; set; }

        // Define a property for the player's email address with email format validation. It allows null values.
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string? Player_Email { get; set; }

        // Define required integer properties for Coach, Team, and Position IDs.
        [Required]
        [Display(Name = "Coach")]
        public int? CoachId { get; set; }

        [Required]
        [Display(Name = "Team")]
        public int? TeamId { get; set; }

        [Required]
        [Display(Name = "Position")]
        public int? PositionId { get; set; }

        // Define virtual navigation properties for Coach, Position, and Team entities. They allow null values.
        public virtual Coach? Coaches { get; set; } = null!;
        public virtual Position? Positions { get; set; } = null!;
        public virtual Team? Teams { get; set; } = null!;

        // Define a collection property for associated transactions and initialize it as an empty list.
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
