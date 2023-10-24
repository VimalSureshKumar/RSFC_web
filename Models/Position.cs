using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Position"
    public partial class Position
    {
        // Define a required integer property for the position's ID with a display name.
        [Required]
        [Display(Name = "Position ID")]
        public int PositionId { get; set; }

        // Define a string property for the position's name with data type and validation rules.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Position")]
        [MaxLength(30)]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid position starting with capital letters.")]
        [Display(Name = "Position")]
        public string Position_Name { get; set; } = null!;

        // Define a collection property for associated players and initialize it as an empty list.
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
