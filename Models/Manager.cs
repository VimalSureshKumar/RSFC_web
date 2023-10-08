namespace RSFC_web.Models
{
    public partial class Manager
    {
        public int ManagerId { get; set; }

        public string Manager_Name { get; set; } = null!;

        public string Manager_Phone_Number { get; set; } = null!;

        public string Manager_Email { get; set; } = null!;

        public string? Manager_Nationality { get; set; }

        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}
