using KOMiT.App.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Model
{
    public class SubProject
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime EstimatedStartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public string Comment { get; set; }
        public DateTime RealizedDate { get; set; }

        public int? ProjectId {get; set;}
        public Project Project { get; set; }

        public ICollection <CurrentSubGoal>? CurrentSubGoals { get; set; }

        public ICollection<Phase> Phases { get; set;}
        public ICollection<SubProjectPhase> SubProjectPhases { get; set; }
    }
}
