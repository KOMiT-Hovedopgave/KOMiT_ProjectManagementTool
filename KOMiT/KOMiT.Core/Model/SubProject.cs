using KOMiT.Core.Model.Enum;
using System.Xml.Linq;

namespace KOMiT.Core.Model;

public class SubProject
{
    public int Id { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public int? ProjectId {get; set;}
    public Project? Project { get; set; }

    public ICollection<CurrentSubGoal>? CurrentSubGoals { get; } 

    public ICollection<Phase> Phases { get; }

    public SubProject()
    {

    }
    public SubProject(int id, Status status, DateTime estimatedStartDate, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, int? projectId, ICollection<Phase> phases)     
    {
        Id = id;
        Status = status;
        EstimatedStartDate = estimatedStartDate;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        ProjectId = id;
        Phases = phases;
    }

}
