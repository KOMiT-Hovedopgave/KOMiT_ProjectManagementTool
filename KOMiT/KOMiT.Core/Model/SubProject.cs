using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;

public class SubProject
{
    public int Id { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string Comment { get; set; }
    public DateTime RealizedDate { get; set; }

    public int? ProjectId {get; set;}
    public Project Project { get; set; }

    public ICollection <CurrentSubGoal>? CurrentSubGoals { get; set; }

    public ICollection<Phase> Phases { get; set;}
    public ICollection<SubProjectPhase> SubProjectPhases { get; set; }
}
