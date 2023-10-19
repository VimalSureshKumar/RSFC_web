using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Coach
    {
        [Required]
        [Display(Name = "Coach ID")]
        public int CoachId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name"), MaxLength(50)]
        [Display(Name = "Full Name")]
        public string Coach_Name { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter Mobile Number"), MaxLength(50)]
        [Display(Name = "Phone Number")]
        public string Coach_Phone_Number { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Coach_Email { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Nationality"), MaxLength(50)]
        [Display(Name = "Nationality")]
        public string? Coach_Nationality { get; set; }

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
