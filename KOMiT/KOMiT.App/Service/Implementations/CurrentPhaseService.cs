using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service.Implementations
{
    public class CurrentPhaseService : ICurrentPhaseService
    {
        private ICurrentPhaseRepository _currentPhaseRepository;

        public CurrentPhaseService(ICurrentPhaseRepository currentPhaseRepository)
        {
            _currentPhaseRepository = currentPhaseRepository;
        }

        public async Task<CurrentPhase> GetDetailsById(int id)
        {
            return await _currentPhaseRepository.GetDetailsById(id);
        }
    }
}
