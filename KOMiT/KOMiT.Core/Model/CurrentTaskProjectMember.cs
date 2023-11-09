using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class CurrentTaskProjectMember
{
    public int CurrentTaskId { get; set; }
    public int ProjectMemberId { get; set; }
    public CurrentTask CurrentTask { get; set; }
    public ProjectMember ProjectMember { get; set; }
}
