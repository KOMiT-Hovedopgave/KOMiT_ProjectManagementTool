using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class Phase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<SubProject>? SubProjects { get; set; }
    public ICollection<SubProjectPhase>? SubProjectPhases { get; set; }

    public ICollection<StandardSubGoal>? StandardSubGoals { get; set; }
}
