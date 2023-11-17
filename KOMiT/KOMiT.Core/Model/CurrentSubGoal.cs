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

    
    public ICollection <CurrentTask>? CurrentTasks { get;  } = new List<CurrentTask>();

    //Join klasse bliver lavet her mellem CurrentSubGoal og ProjectMember
    public ICollection<ProjectMember>? ProjectMembers { get; } = new List<ProjectMember>();
}
