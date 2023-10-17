using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Player
    {
        [Required]
        [Display(Name = "Player ID")]
        public int PlayerId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Full Name"), MaxLength(50)]
        [Display(Name = "Full Name")]
        public string Player_Name { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Gender"), MaxLength(6)]
        [Display(Name = "Gender")]
        public string? Player_Gender { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Date of Birth")]
        [Display(Name = "Date of Birth")]
        public DateTime Player_Dob { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Phone Number")]
        public string? Player_Phone_Number { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string? Player_Email { get; set; }

        [Required]
        [Display(Name = "Coach ID")]
        public int CoachId { get; set; }

        [Required]
        [Display(Name = "Team ID")]
        public int TeamId { get; set; }

        [Required]
        [Display(Name = "Position ID")]
        public int PositionId { get; set; }

        public virtual Coach Coaches { get; set; } = null!;

        public virtual Position Positions { get; set; } = null!;

        public virtual Team Teams { get; set; } = null!;

        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
