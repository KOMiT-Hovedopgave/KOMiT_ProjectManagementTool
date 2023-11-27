using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using KOMiT.DataAccess.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KOMiT.Core.DTO_s.EstimatedAndRealizedDaysDTO;

namespace KOMiT.App.Service.Implementations
{
    public class CurrentPhaseService : ICurrentPhaseService
    {
        private ICurrentPhaseRepository _currentPhaseRepository;
        private EstimatedAndRealizedDaysDTO _estimatedAndRealizedDaysDTO;

        public CurrentPhaseService(ICurrentPhaseRepository currentPhaseRepository)
        {
            _currentPhaseRepository = currentPhaseRepository;
        }

        public async Task<CurrentPhase> GetDetailsById(int id)
        {
            return await _currentPhaseRepository.GetDetailsById(id);

        }

        public async Task<EstimatedAndRealizedDaysDTO> CalculatorEstimatedAndRealizedDaysDTO(int id)
        {
            var result = await _currentPhaseRepository.GetEstimatedAndRealizedData(id);
            double estimatedSubProjectDays = CalculateDateDays(result.EstimatedEndDate, result.EstimatedStartDate);
            double realizedSubProjectsDays = 0;

            if (result.RealizedDate.HasValue)
            {
                realizedSubProjectsDays = CalculateDateDays(result.RealizedDate.Value, result.EstimatedStartDate);
            }

            List<double> estimatedCurrentSubGoalsDays = new List<double>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                var subGoalsDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate);
                estimatedCurrentSubGoalsDays.Add(subGoalsDays);
            }

            List<double> realizedCurrentSubGoalsDays = new List<double>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                if (currentSubGoal.RealizedDate.HasValue)
                {
                    var subGoalsDays = CalculateDateDays(currentSubGoal.RealizedDate.Value, currentSubGoal.EstimatedEndDate);
                    realizedCurrentSubGoalsDays.Add(subGoalsDays);
                }
            }

            List<double> estimatedCurrentTasksDays = new List<double>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                foreach (var currentTasks in currentSubGoal.CurrentTasks)
                {
                    var currentTasksDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, currentTasks.EstimatedNumberOfDays);
                    estimatedCurrentTasksDays.Add(currentTasksDays);
                }
            }

            List<double> realizedCurrentTasksDays = new List<double>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                foreach (var currentTasks in currentSubGoal.CurrentTasks)
                {
                    if(currentTasks.RealizedDate.HasValue)
                    {
                        var currentTasksDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, currentTasks.RealizedDate.Value);
                        realizedCurrentTasksDays.Add(currentTasksDays);
                    }
                }
            }

            List<CurrentSubGoalsDaysDTO> currentSubGoalsDaysDTOs = new List<CurrentSubGoalsDaysDTO>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                if (currentSubGoal.RealizedDate.HasValue)
                {
                    currentSubGoalsDaysDTOs.Add(new CurrentSubGoalsDaysDTO
                    { Name = currentSubGoal.Name, EstimatedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate),
                      RealizedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.RealizedDate.Value, currentSubGoal.EstimatedEndDate)});
                }
                else
                {
                    currentSubGoalsDaysDTOs.Add(new CurrentSubGoalsDaysDTO
                    {
                        Name = currentSubGoal.Name,
                        EstimatedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate),
                        RealizedCurrentSubGoalsDays = 0
                    });
                }
            }

            List<CurrentTaskDaysDTO> currentTasksDaysDTO = new List<CurrentTaskDaysDTO>();
            foreach (var currentSubGoal in result.CurrentSubGoals)
            {
                foreach(var currenTask in currentSubGoal.CurrentTasks)
                {
                    if (currenTask.RealizedDate.HasValue)
                    {
                        currentTasksDaysDTO.Add(new CurrentTaskDaysDTO
                        {
                            Title = currenTask.Title,
                            EstimatedCurrentTaksDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, currenTask.EstimatedNumberOfDays),
                            RealizedCurrentTaksDays = CalculateDateDays(currenTask.RealizedDate.Value, currentSubGoal.EstimatedEndDate)
                        });
                    }
                    else
                    {
                        currentTasksDaysDTO.Add(new CurrentTaskDaysDTO
                        {
                            Title = currenTask.Title,
                            EstimatedCurrentTaksDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, currenTask.EstimatedNumberOfDays),
                            RealizedCurrentTaksDays = 0
                        });
                    }
                }
            }



            return _estimatedAndRealizedDaysDTO = new EstimatedAndRealizedDaysDTO(estimatedSubProjectDays, realizedSubProjectsDays, estimatedCurrentSubGoalsDays.Sum(), realizedCurrentSubGoalsDays.Sum(), estimatedCurrentTasksDays.Sum(), realizedCurrentTasksDays.Sum(), currentSubGoalsDaysDTOs, currentTasksDaysDTO);
        }

       

        public double CalculateDateDays(DateTime endDate, DateTime startDate)
        {
            return (endDate - startDate).TotalDays;
        }
    }
}
