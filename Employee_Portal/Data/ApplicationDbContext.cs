using Employee_Portal.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Portal.Data
{
    public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

            {

            }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Skill_Id> Skill_Ids { get; set;}
            public DbSet<Skill_Management> Skill_Managements { get; set;}
            
            public DbSet<Role> Roles { get; set; }
            public DbSet<Login> Logins { get; set; }

    }
    
}
