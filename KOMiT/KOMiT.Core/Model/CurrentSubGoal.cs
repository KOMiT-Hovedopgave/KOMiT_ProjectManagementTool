﻿using KOMiT.Core.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.Model;

public class CurrentSubGoal
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Navn for lang")]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public Status Status { get; set; }
    [Required]
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public int? CurrentPhaseId { get; set; }
    public CurrentPhase? CurrentPhase { get; set; }

    public ICollection <CurrentTask>? CurrentTasks { get; set; } 

    public CurrentSubGoal()
    {

    }

    public CurrentSubGoal(int id, string name, string description, Status status, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, ICollection<CurrentTask>? currentTasks)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        CurrentTasks = currentTasks;
    }
}
