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

    public int? SubProjectId { get; set; }
    public SubProject? SubProject { get; set; }

    public ICollection <CurrentTask>? CurrentTasks { get;  }

    public ICollection <ProjectMember>? ProjectMembers { get; }
}
