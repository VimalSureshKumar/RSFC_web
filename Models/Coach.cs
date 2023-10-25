using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Coach"
    public partial class Coach
    {
        // This property represents the Coach's unique identifier.
        [Required] // It ensures that the CoachId is mandatory and cannot be null or left empty.
        [Display(Name = "Coach ID")] // Sets the display name for this property.
        public int CoachId { get; set; }

        // This property represents the Coach's full name.
        [DataType(DataType.Text)] // Specifies that it contains text data.
        [Required(ErrorMessage = "Please enter Full Name"), MaxLength(50)] // Makes sure the full name is mandatory and provides a error message if not provided and Limits the full name to a maximum of 50 characters.
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid fullname starting with capital letters.")] // Validates that the full name follows the specific format and provides a error message if not.
        [Display(Name = "Full Name")]
        public string Coach_Name { get; set; } = null!;

        // This property represents the Coach's phone number.
        [DataType(DataType.PhoneNumber)] // Specifies that it contains a phone number.
        [Required(ErrorMessage = "Please enter Mobile Number"), MaxLength(17)] // Ensures the phone number is mandatory and provides a error message if not provided and Limits the phone number to a maximum of 17 characters.
        [RegularExpression(@"^\(\+64\) \d{2}-\d{3}-\d{4}$", ErrorMessage = "Phone Number is not valid. Accepted format (+64) 12-345-6789 for example.")] // Validates that the phone number follows the specific format and provides a error message if not and how it is accepted.
        [Display(Name = "Phone Number")]
        public string Coach_Phone_Number { get; set; } = null!;

        // This property represents the Coach's email address.
        [DataType(DataType.EmailAddress)] // Specifies that it contains an email address.
        [Required(ErrorMessage = "Please enter Email")] // Ensures the email address is mandatory and provides a error message if not provided.
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")] // Validates that the email address follows the specific format and provides a error message if not.
        [Display(Name = "Email")]
        public string Coach_Email { get; set; } = null!;

        // This property represents the Coach's nationality.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Nationality"), MaxLength(50)] // Ensures that the nationality is mandatory and provides a custom error message if not provided and Limits the nationality to a maximum of 50 characters.
        [RegularExpression(@"^([A-z][A-Za-z]*\s*[A-Za-z]*)$", ErrorMessage = "Nationality is not valid")] // Validates that the nationality follows the specific format and provides a error message if not.
        [Display(Name = "Nationality")]
        public string? Coach_Nationality { get; set; }

        // This property represents a collection of players associated with the coach.
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
