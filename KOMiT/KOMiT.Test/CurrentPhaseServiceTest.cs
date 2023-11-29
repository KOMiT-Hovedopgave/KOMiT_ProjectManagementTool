﻿using KOMiT.App.Service;
using KOMiT.App.Service.Implementations;
using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KOMiT.Core.DTO_s.EstimatedAndRealizedDaysDTO;

namespace KOMiT.Test
{
    public class CurrentPhaseServiceTest
    {
        public class CurrentPhaseServiceTests
        {
            
            [Fact]
            public async Task CalculatorEstimatedAndRealizedDaysDTO_ShouldReturnValidDTO()
            {
                // Arrange
                int id = 1;
                var mockRepository = new Mock<ICurrentPhaseRepository>();
                var service = new CurrentPhaseService(mockRepository.Object);

                // Set up mock repository to return expected data
                var mockResult = new CurrentPhase
                {
                    ProjectId = 1,
                    Id = 1,
                    Status = Core.Model.Enum.Status.Aktiv,
                    EstimatedStartDate = new DateTime(2023, 11, 09),
                    EstimatedEndDate = new DateTime(2025, 12, 24),
                    StandardPhaseId = 1,
                    CurrentSubGoals = new List<CurrentSubGoal>
                    {
                        new CurrentSubGoal 
                        { Id = 1, Name = "E2E Test", Description ="Dette delmål", Status = 0, EstimatedEndDate = new DateTime(2024,01,09), RealizedDate = new DateTime(2024,01,05),
                            CurrentTasks = new List<CurrentTask>
                            { new CurrentTask { Title = "Implementere textfixture for E2E", Description = "Denne opgave...", Status = 0, EstimatedNumberOfDays = new DateTime(2023, 12, 30), RealizedDate = new DateTime(2024, 01, 01)} } },

                         new CurrentSubGoal { Id = 2, Name = "Unit test", Description ="Dette delmål", Status = 0, EstimatedEndDate = new DateTime(2024,06,09), RealizedDate = new DateTime(2024,11,05),
                            CurrentTasks = new List<CurrentTask>
                            { new CurrentTask { Title = "Implementere unit test", Description = "Denne opgave...", Status = 0, EstimatedNumberOfDays = new DateTime(2024, 07, 30), RealizedDate = new DateTime(2024, 08, 01)} } }
                    },
                    RealizedDate = new DateTime(2025, 12, 10),
                    Comment = "Dette er en realiseret kommentar"
                };
                mockRepository.Setup(repo => repo.GetEstimatedAndRealizedData(id)).ReturnsAsync(mockResult);

                double estimatedSubProjectDays = 776;
                double realizedSubProjectsDays = 762;
                double estimatedCurrentSubGoalsDays = 61 + 213;
                double realizedCurrentSubGoalsDays = 57 + 362;
                double estimatedCurrentTasksDays = 51 + 264;
                double realizedCurrentTasksDays = 53 + 266;
                List<CurrentSubGoalsDaysDTO> currentSubGoalsDaysDTOs = new List<CurrentSubGoalsDaysDTO>
                {
                    new CurrentSubGoalsDaysDTO {Name = "E2E Test", EstimatedCurrentSubGoalsDays = 61, RealizedCurrentSubGoalsDays = 57},
                    new CurrentSubGoalsDaysDTO {Name = "Unit test", EstimatedCurrentSubGoalsDays = 213, RealizedCurrentSubGoalsDays = 362},

                };
                List<CurrentTaskDaysDTO> currentTasksDaysDTO = new List<CurrentTaskDaysDTO> 
                { 
                    new CurrentTaskDaysDTO { Title = "Implementere textfixture for E2E", EstimatedCurrentTaksDays = 51, RealizedCurrentTaksDays = 53 },
                    new CurrentTaskDaysDTO { Title = "Implementere unit test", EstimatedCurrentTaksDays = 264, RealizedCurrentTaksDays = 266 }
                };

                // Act
                var result = await service.CalculatorEstimatedAndRealizedDaysDTO(id);
               
                // Assert
                Assert.NotNull(result);
                Assert.Equal(estimatedSubProjectDays, result.EstimatedCurrentPhaseDaysSum);
                Assert.Equal(realizedSubProjectsDays, result.RealizedCurrentPhaseDaysSum);
                Assert.Equal(estimatedCurrentSubGoalsDays, result.EstimatedCurrentSubGoalsDaysSum);
                Assert.Equal(realizedCurrentSubGoalsDays, result.RealizedCurrentSubGoalsDaysSum);
                Assert.Equal(estimatedCurrentTasksDays, result.EstimatedCurrentTaskDaysSum);
                Assert.Equal(realizedCurrentTasksDays, result.RealizedCurrentTaskDaysSum);
                //Assert.Equal(currentSubGoalsDaysDTOs, result.CurrentSubGoalsDaysDTOs);
                //Assert.Equal(currentTasksDaysDTO, result.CurrentTaskDaysDTOs);
            }
        }
    }
}