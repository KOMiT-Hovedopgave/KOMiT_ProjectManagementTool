using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;

public class ProjectMember
{
    public int Id { get; set; }
    public string ProjectRole { get; set; }
    public Status Status { get; set; }

    public ICollection <CurrentTask>? CurrentTasks { get; }

    public ICollection <CurrentSubGoal>? CurrentSubGoals { get; }

    public ICollection <Employee>? Employees { get; }
}
