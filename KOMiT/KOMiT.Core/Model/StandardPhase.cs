using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class StandardPhase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<CurrentPhase> CurrentPhases { get; } = new List<CurrentPhase>();

    public ICollection<StandardSubGoal>? StandardSubGoals { get; set; } = new List<StandardSubGoal>();

    public StandardPhase() : this(0, "", "") { }
    public StandardPhase(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public StandardPhase(int id, string name, string description, ICollection<StandardSubGoal?> standardSubGoals) : this(id, name, description)
    {
        StandardSubGoals = standardSubGoals;
    }


}
