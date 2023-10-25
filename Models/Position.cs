using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Position"
    public partial class Position
    {
        // This property represents the Position's unique identifier.
        [Required]
        [Display(Name = "Position ID")]
        public int PositionId { get; set; }

        // This property represents the Position's name.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Position"), MaxLength(30)] // Limits the position to a maximum of 30 characters.
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid position starting with capital letters.")]
        [Display(Name = "Position")]
        public string Position_Name { get; set; } = null!;

        // This property represents a collection of associated players.
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
