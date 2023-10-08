namespace RSFC_web.Models
{
    public partial class Coach
    {
        public int CoachId { get; set; }

        public string Coach_Name { get; set; } = null!;

        public string Coach_Phone_Number { get; set; } = null!;

        public string Coach_Email { get; set; } = null!;

        public string? Coach_Nationality { get; set; }

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
