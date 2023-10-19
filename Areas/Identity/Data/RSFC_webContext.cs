using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RSFC_web.Areas.Identity.Data;
using RSFC_web.Models;

namespace RSFC_web.Data;
[Authorize]
public class RSFC_webContext : IdentityDbContext<AppUser>
{
    public RSFC_webContext(DbContextOptions<RSFC_webContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<RSFC_web.Models.Coach> Coach { get; set; } = default!;

    public DbSet<RSFC_web.Models.Manager> Manager { get; set; } = default!;

    public DbSet<RSFC_web.Models.Player> Player { get; set; } = default!;

    public DbSet<RSFC_web.Models.Transaction> Transaction { get; set; } = default!;

    public DbSet<RSFC_web.Models.Team> Team { get; set; } = default!;

    public DbSet<RSFC_web.Models.Position> Position { get; set; } = default!;
}
