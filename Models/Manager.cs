using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Manager
    {
        [Required]
        [Display(Name = "Manager ID")]
        public int ManagerId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name"), MaxLength(50)]
        [Display(Name = "Full Name")]
        public string Manager_Name { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Phone Number")]
        public string Manager_Phone_Number { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Manager_Email { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Nationality"), MaxLength(50)]
        [Display(Name = "Nationality")]
        public string? Manager_Nationality { get; set; }

        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
