using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service.Implementations
{
    public class CurrentSubGoalService : ICurrentSubGoalService
    {
        private ICurrentSubGoalRepository _currentSubGoalRepository;

        public CurrentSubGoalService(ICurrentSubGoalRepository currentSubGoalRepository)
        {
            _currentSubGoalRepository = currentSubGoalRepository;
        }

        public async Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal)
        {
            await _currentSubGoalRepository.CreateCurrentSubGoal(currentSubGoal);
        }

        public async Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal)
        {
            await _currentSubGoalRepository.FinishCurrentSubGoal(currentSubGoal);
        }
    }
}
