using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;

public class ProjectMember
{
    public int Id { get; set; }
    public string ProjectRole { get; set; }
    public ProjectMemberStatus ProjectMemberStatus { get; set; }

    public ICollection<CurrentPhase>? CurrentPhases { get; set; } = new List<CurrentPhase>();

    public ICollection<CurrentTask>? CurrentTasks { get; } 

    public ICollection<Employee>? Employees { get; set; } = new List<Employee>();

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
