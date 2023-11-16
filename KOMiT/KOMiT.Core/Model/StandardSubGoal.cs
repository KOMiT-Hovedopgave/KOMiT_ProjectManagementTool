using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;

public class StandardSubGoal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public int? PhaseId { get; set; }
    public StandardPhase? Phase {get; set;}

    public ICollection<StandardTask>? StandardTasks { get; } = new List<StandardTask>();
}
