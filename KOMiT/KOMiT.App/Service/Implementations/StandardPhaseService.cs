using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service.Implementations
{
    public class StandardPhaseService : IStandardPhaseService
    {
        private IStandardPhaseRepository _standardPhaseRepository;

        public StandardPhaseService(IStandardPhaseRepository standardPhaseRepository)
        {
            _standardPhaseRepository = standardPhaseRepository;
        }
        public async Task CreatePhase(StandardPhase standardPhase)
        {
             await _standardPhaseRepository.CreatePhase(standardPhase);
        }
    }
}
