using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories.Implementations
{
    public class CurrentSubGoalRepository : ICurrentSubGoalRepository
    {
        private DatabaseContext _context;
        public CurrentSubGoalRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal)
        {
            _context.CurrentSubGoals.Add(currentSubGoal);
            await _context.SaveChangesAsync();
        }

        public async Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal)
        {
            _context.CurrentSubGoals.Update(currentSubGoal);
            await _context.SaveChangesAsync();
        }

    }
}
