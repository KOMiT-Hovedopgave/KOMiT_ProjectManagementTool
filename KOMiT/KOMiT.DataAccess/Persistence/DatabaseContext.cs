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
    public DbSet<CurrentPhase> CurrentPhases { get; set; }
    public DbSet<CurrentSubGoal> CurrentSubGoals { get; set; }
    public DbSet<CurrentTask> CurrentTasks { get; set; }
    public DbSet<StandardPhase> StandardPhases { get; set; }
    public DbSet<StandardSubGoal> StandardSubGoals { get; set; }
    public DbSet<StandardTask> StandardTasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Name = "Skema og tid",
                Description = "Dette projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Udvikling,
                Priority = Core.Model.Enum.Priority.Høj,
                EstimatedStartDate = new DateTime(2023, 11, 09),
                EstimatedEndDate = new DateTime(2024, 12, 09),
            },
            new Project
            {
                Id = 2,
                Name = "ElevDataPro",
                Description = "Dette projekt...",
                ProjectType = Core.Model.Enum.ProjectType.Drift,
                EstimatedStartDate = new DateTime(2024, 01, 01),
                EstimatedEndDate = new DateTime(2025, 01, 01),
            }
            );

        modelBuilder.Entity<CurrentPhase>().HasData(
            new CurrentPhase
            {
                ProjectId = 1,
                Id = 1,
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedStartDate = new DateTime(2023, 11, 09),
                EstimatedEndDate = new DateTime(2023, 12, 24),
                StandardPhaseId= 1,
            },
            new CurrentPhase
            {
                ProjectId = 2,
                Id = 2,
                Status = Core.Model.Enum.Status.Inaktiv,
                EstimatedStartDate = new DateTime(2024, 11, 09),
                EstimatedEndDate = new DateTime(2024, 12, 24),
                StandardPhaseId= 2,
            }
            );


        modelBuilder.Entity<StandardPhase>().HasData(
           new StandardPhase
           {
               Id = 1,
               Name = "Testning",
               Description = "Denne fase..."

           },
           new StandardPhase
           {
               Id = 2,
               Name = "Opstartsfase",
               Description = "Denne fase..."
           }
           );

        modelBuilder.Entity<StandardSubGoal>().HasData(
            new StandardSubGoal
            {
                Id = 1,
                Name = "E2E test",
                Description = "Dette delmål...",
                PhaseId = 1
            },
            new StandardSubGoal
            {
                Id = 2,
                Name = "Unit Testing",
                Description = "Dette delmål...",
                PhaseId = 1
            },
            new StandardSubGoal
            {
                Id = 3,
                Name = "Integration",
                Description = "Dette delmål...",
                PhaseId = 1
            }
           );

        modelBuilder.Entity<StandardTask>().HasData(
           new StandardTask
           {
               Id = 1,
               Title = "Implementer test fixture for E2E",
               Description = "Denne opgave...",
               StandardSubGoalId = 1
           },
           new StandardTask
           {
               Id = 2,
               Title = "Unit Testing",
               Description = "Denne opgave...",
               StandardSubGoalId = 2
           },
           new StandardTask
           {
               Id = 3,
               Title = "Implementere test fixture for integration",
               Description = "Denne opgave...",
               StandardSubGoalId = 3
           },
             new StandardTask
             {
                 Id = 4,
                 Title = "Test database",
                 Description = "Denne opgave...",
                 StandardSubGoalId = 3
             }
           );

        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Pia Olsen",
                JobPosition = "Udvikler",
                Email = "pia@komit.dk",
            },
            new Employee
            {
                Id = 2,
                Name = "Per Hansen",
                JobPosition = "Konsulent",
                Email = "per@komit.dk",
            }
            );

        modelBuilder.Entity<Competence>().HasData(
            new Competence
            {
                Id = 1,
                Title = "SQL",
                Description = "Jeg føler mig stærk i...",
                Experience = "5 år",
                EmployeeId = 2
            },
            new Competence
            {
                Id = 2,
                Title = "C#",
                Description = "Jeg føler mig stærk i...",
                Experience = "4 år",
                EmployeeId = 2
            },
            new Competence
            {
                Id = 3,
                Title = "Blazor",
                Description = "Jeg føler mig stærk i...",
                Experience = "6 år",
                EmployeeId = 1
            }
            );

        modelBuilder.Entity<ProjectMember>().HasData(
            new ProjectMember
            {
                Id = 1,
                ProjectRole = "Udvikler",
                ProjectMemberStatus = Core.Model.Enum.ProjectMemberStatus.Aktiv,
            }
            );

        modelBuilder.Entity("CurrentSubGoalProjectMember").HasData(
         new { CurrentSubGoalsId = 1, ProjectMembersId = 1 }
         );



        modelBuilder.Entity("CurrentTaskProjectMember").HasData(
            new { CurrentTasksId = 1, ProjectMembersId = 1 }
            );


        modelBuilder.Entity("EmployeeProjectMember").HasData(
            new { EmployeesId = 1, ProjectMembersId = 1 }
            );


        modelBuilder.Entity<CurrentSubGoal>().HasData(
           new CurrentSubGoal
           {
               Id = 1,
               Name = "E2E",
               Description = "Dette delmål...",
               Status = Core.Model.Enum.Status.Aktiv,
               EstimatedEndDate = new DateTime(2024, 11, 09),
               SubProjectId = 1
           }
           );

        modelBuilder.Entity<CurrentTask>().HasData(
            new CurrentTask
            {
                Id = 1,
                Title = "Implementere textfixture for E2E",
                Description = "Denne opgave...",
                Status = Core.Model.Enum.Status.Aktiv,
                EstimatedNumberOfDays = new DateTime(2023, 11, 10),
                CurrentSubGoalId= 1,
            }
            );

    }

}

