using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class CurrentSubGoalProjectMember
{
    public int CurrentSubGoalId { get; set; }
    public int CurrentTaskId { get; set; }
    public CurrentSubGoal CurrentSubGoal { get; set; }
    public CurrentTask CurrentTask { get; set; }
}
