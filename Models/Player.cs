namespace RSFC_web.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }

        public string Player_Name { get; set; } = null!;

        public string? Player_Gender { get; set; }

        public DateTime Player_Dob { get; set; }

        public string? Player_Phone_Number { get; set; }

        public string? Player_Email { get; set; }

        public int CoachId { get; set; }

        public int TeamId { get; set; }

        public int PositionId { get; set; }

        public virtual Coach Coaches { get; set; } = null!;

        public virtual Position Positions { get; set; } = null!;

        public virtual Team Teams { get; set; } = null!;

        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
