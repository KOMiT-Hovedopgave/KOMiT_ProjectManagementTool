﻿using System;
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
    public StandardPhase? StandardPhase {get; set;}

    public ICollection<StandardTask>? StandardTasks { get; set; } = new List<StandardTask>();

     public StandardSubGoal()
    {

    }
    public StandardSubGoal(int id, string name, string description, ICollection<StandardTask>? standardTasks)
    {
        Id = id;
        Name = name;
        Description = description;
        StandardTasks = standardTasks;
    }
}
