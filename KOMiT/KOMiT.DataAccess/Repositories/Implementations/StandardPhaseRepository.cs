using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories.Implementations
{
    public class StandardPhaseRepository : IStandardPhaseRepository 
    {
        private DatabaseContext _context;
        public StandardPhaseRepository(DatabaseContext context)
        {
           _context= context;
        }
        public async Task<ICollection<StandardPhase>> CreatePhase()
        {
            var result = _context.StandardPhases.Select(x => new StandardPhase(
                x.Id,
                x.Name,
                x.Description)).ToList();
            return  await result.ToList();
        }
    }
}
