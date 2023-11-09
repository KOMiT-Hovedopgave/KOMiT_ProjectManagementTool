using KOMiT.Core.Model.Enum;
namespace KOMiT.Core.Model;
    public class CurrentTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CurrentTaskStatus CurrentTaskStatus { get; set; }
        public DateTime EstimatedNumberOfDays { get; set; }
        public string? Comment{ get; set; } 
        public DateTime? RealizedDate { get; set; }

        public int? CurrentSubGoalId { get; set; }
        public CurrentSubGoal? CurrentSubGoal { get; set; }

        public ICollection<ProjectMember>? ProjectMembers { get; set; }
        public ICollection<CurrentTaskProjectMember>? CurrentTaskProjectMembers { get; set; }
    }

