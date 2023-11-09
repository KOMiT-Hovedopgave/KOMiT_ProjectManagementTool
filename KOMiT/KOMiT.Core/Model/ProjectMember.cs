using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;

public class ProjectMember
{
    public int Id { get; set; }
    public string ProjectRole { get; set; }
    public Status Status { get; set; }

    public ICollection <ProjectMember>? ProjectMembers { get; set; }
    public ICollection<CurrentSubGoalProjectMember>? CurrentSubGoalProjectMembers { get; set; }

    public ICollection <CurrentTask>? CurrentTasks { get; set; }
    public ICollection<CurrentTaskProjectMember>? CurrentTaskProjectMembers { get; set; }

    public ICollection <Employee>? Employees { get; set; }
}
