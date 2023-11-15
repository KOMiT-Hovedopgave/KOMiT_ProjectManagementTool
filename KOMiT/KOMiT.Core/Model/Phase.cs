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

    public ICollection<SubProject> SubProjects { get; } = new List<SubProject>();

    public ICollection<StandardSubGoal>? StandardSubGoals { get; } = new List<StandardSubGoal>();

    public Phase() { }
    public Phase(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
