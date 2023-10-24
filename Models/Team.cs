using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Team"
    public partial class Team
    {
        // Define a required integer property for the team's ID with a display name.
        [Required]
        [Display(Name = "Team ID")]
        public int TeamId { get; set; }

        // Define a string property for the team's name with data type and validation rules.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Team")]
        [MaxLength(30)]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*){1,2}$", ErrorMessage = "Please enter a valid team name starting with capital letters.")]
        [Display(Name = "Team")]
        public string Team_Name { get; set; } = null!;

        // Define a required integer property for the team's manager with a display name. It allows null values.
        [Required]
        [Display(Name = "Manager")]
        public int? ManagerId { get; set; }

        // Define a virtual navigation property for the team's manager entity. It allows null values.
        public virtual Manager? Managers { get; set; } = null!;

        // Define a collection property for associated players and initialize it as an empty list.
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}

