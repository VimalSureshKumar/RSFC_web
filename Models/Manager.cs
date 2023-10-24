using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Manager"
    public partial class Manager
    {
        // Define a required integer property for the manager's ID with a display name.
        [Required]
        [Display(Name = "Manager ID")]
        public int ManagerId { get; set; }

        // Define a string property for the manager's full name with data type and validation rules.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name")]
        [MaxLength(50)]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid fullname starting with capital letters.")]
        [Display(Name = "Full Name")]
        public string Manager_Name { get; set; } = null!;

        // Define a string property for the manager's phone number with data type, required validation, and format validation.
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [RegularExpression(@"^\(\+64\) \d{2}-\d{3}-\d{4}$", ErrorMessage = "Phone Number is not valid. Accepted format (+64) 12-345-6789 for example.")]
        [Display(Name = "Phone Number")]
        public string Manager_Phone_Number { get; set; } = null!;

        // Define a string property for the manager's email address with data type and required validation.
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Manager_Email { get; set; } = null!;

        // Define a string property for the manager's nationality with data type, length validation, and format validation. It allows null values.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Nationality")]
        [MaxLength(50)]
        [RegularExpression(@"^([A-z][A-Za-z]*\s*[A-Za-z]*)$", ErrorMessage = "Nationality is not valid")]
        [Display(Name = "Nationality")]
        public string? Manager_Nationality { get; set; }

        // Define a collection property for associated teams and initialize it as an empty list.
        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
