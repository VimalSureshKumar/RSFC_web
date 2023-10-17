using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Team
    {
        [Required]
        [Display(Name = "Team ID")]
        public int TeamId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Team"), MaxLength(50)]
        [Display(Name = "Team")]
        public string Team_Name { get; set; } = null!;

        [Required]
        [Display(Name = "Manager ID")]
        public int ManagerId { get; set; }

        public virtual Manager Managers { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
