using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProjectType ProjectType { get; set; } 
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public ICollection<SubProject>? SubProjects { get; } = new List<SubProject>();

    public  Project()
    {

    }

    public Project(int id, string name, string description, ProjectType projectType, Priority priority, Status status, DateTime estimatedStartDate, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, ICollection<SubProject>? subProjects)
    {
        Id = id;
        Name = name;
        Description = description;
        ProjectType = projectType;
        Priority = priority;
        Status = status;
        EstimatedStartDate = estimatedStartDate;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        SubProjects = subProjects;
    }
}
