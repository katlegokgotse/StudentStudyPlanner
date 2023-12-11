using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentPlanner.Areas.Identity.Data;
using StudentPlanner.Models;

namespace StudentPlanner.Data;

public class StudentPlannerDbContext : IdentityDbContext<ApplicationUser>
{
    public StudentPlannerDbContext(DbContextOptions<StudentPlannerDbContext> options)
        : base(options)
    {
    }
    public DbSet<Courses> Courses { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
