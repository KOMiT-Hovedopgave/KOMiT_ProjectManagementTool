using KOMiT.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class CurrentSubGoal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public int? CurrentPhaseId { get; set; }
    public CurrentPhase? CurrentPhase { get; set; }

    public ICollection <CurrentTask>? CurrentTasks { get; set; } 

    //Join klasse bliver lavet her mellem CurrentSubGoal og ProjectMember
    public ICollection<ProjectMember>? ProjectMembers { get; set; } 

    public CurrentSubGoal()
    {

    }

    public CurrentSubGoal(int id, string name, string description, Status status, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, ICollection<CurrentTask>? currentTasks, ICollection<ProjectMember>? projectMembers)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        CurrentTasks = currentTasks;
        ProjectMembers = projectMembers;
    }
}
