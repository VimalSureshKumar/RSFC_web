using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace RSFC_web.Models
{
    // Define a C# class named "Team"
    public partial class Team
    {
        // This property represents the Team's unique identifier.
        [Required]
        [Display(Name = "Team ID")]
        public int TeamId { get; set; }

        // This property represents the Team's name.
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter valid Team"), StringLength(30)] // Limits the team to a maximum of 30 characters.
        [Display(Name = "Team")]
        public string Team_Name { get; set; } = null!;

        // This property represents the Team's manager.
        [Required]
        [Display(Name = "Manager")]
        public int? ManagerId { get; set; }

        // This property represents a virtual navigation property for the Team's manager entity.
        public virtual Manager? Managers { get; set; } = null!;

        // This property represents a collection of associated players.
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}

