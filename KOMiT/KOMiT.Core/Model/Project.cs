﻿using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProjectType ProjectType { get; set; } 
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public ICollection<SubProject>? SubProjects { get; set;}
}