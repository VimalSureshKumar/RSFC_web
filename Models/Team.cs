namespace RSFC_web.Models
{
    public partial class Team
    {
        public int TeamId { get; set; }

        public string Team_Name { get; set; } = null!;

        public int ManagerId { get; set; }

        public virtual Manager Managers { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
