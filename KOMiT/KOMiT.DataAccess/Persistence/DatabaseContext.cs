using KOMiT.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Persistence;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<SubProject> SubProjects { get; set; }
    public DbSet<CurrentSubGoal> CurrentSubGoals { get; set; }
    public DbSet<CurrentTask> CurrentTasks { get; set; }
    public DbSet<StandardSubGoal> StandardSubGoals { get; set; }
    public DbSet<StandardTask> StandardTasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id= 1,
                Name= "Skema og tid",
                Description= "Dette projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                EstimatedStartDate = DateTime.Now,
                EstimatedEndDate = new DateTime(2023, 12, 09),
            },
            new Project
            {
                Id = 2,
                Name = "Skema og tid",
                Description = "Dette projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                EstimatedStartDate = DateTime.Now,
                EstimatedEndDate = new DateTime(2023, 12, 09),
            }
            );
        //modelBuilder.Entity<SubProject>().HasData(
        //    new SubProject
        //    {
        //        ProjectId= 1,
        //    }
        //    );

    }

}
