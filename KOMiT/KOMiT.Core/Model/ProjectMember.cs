using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;

public class ProjectMember
{
    public int Id { get; set; }
    public string ProjectRole { get; set; }
    public ProjectMemberStatus ProjectMemberStatus { get; set; }

    public ICollection<CurrentSubGoal>? CurrentSubGoals { get; } = new List<CurrentSubGoal>();

    public ICollection<CurrentTask>? CurrentTasks { get; } = new List<CurrentTask>();

    public ICollection<Employee>? Employees { get; } = new List<Employee>();

    public ProjectMember()
    {

    }
    
    public ProjectMember(int id)
    {
        Id = id;
    }
    public ProjectMember(int id, string projectRole, ProjectMemberStatus projectMemberStatus, ICollection<Employee>? employees) : this(id)
    {
        ProjectRole = projectRole;
        ProjectMemberStatus = projectMemberStatus;
        Employees = employees;
    }
}
