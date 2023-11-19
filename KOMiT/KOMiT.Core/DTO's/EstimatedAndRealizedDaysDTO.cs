using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.Core.DTO_s
{
    public class EstimatedAndRealizedDaysDTO
    {
        public int EstimatedSubProjectDays { get; set; } = 0;
        public int RealizedSubProjectDays { get; set; } = 0;
        public int EstimatedCurrentSubGoalsDays { get; set; } = 0;
        public int RealizedCurrentSubGoalsDays { get; set; } = 0;
        public int EstimatedCurrentTaskDays { get; set; } = 0;
        public int RealizedCurrentTaskDays { get; set; } = 0;

        public EstimatedAndRealizedDaysDTO(int estimatedSubProjectDays, int realizedSubProjectDays, int estimatedCurrentSubGoalsDays, int realizedCurrentSubGoalDays, int estimatedCurrentTaskDays, int realizedCurrentTaskDays) 
        { 
            EstimatedSubProjectDays = estimatedSubProjectDays;
            RealizedSubProjectDays = realizedSubProjectDays;
            EstimatedCurrentSubGoalsDays= estimatedCurrentSubGoalsDays;
            RealizedCurrentSubGoalsDays = realizedCurrentSubGoalDays;
            EstimatedCurrentTaskDays = realizedCurrentTaskDays;
            RealizedCurrentTaskDays= realizedCurrentTaskDays;
       
        }    

    }
}
