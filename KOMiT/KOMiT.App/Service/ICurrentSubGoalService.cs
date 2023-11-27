using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service
{
    public interface ICurrentSubGoalService
    {
        Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal);
        Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal);

        Task UpdateCurrentSubGoal(CurrentSubGoal currentSubGoal);
        Task DeleteCurrentSubGoal(int id);
    }
}
