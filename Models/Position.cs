using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    public partial class Position
    {
        [Required]
        [Display(Name = "Position ID")]
        public int PositionId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Position"), MaxLength(30)]
        [Display(Name = "Position")]
        public string Position_Name { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
