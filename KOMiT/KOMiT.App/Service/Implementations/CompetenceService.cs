using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service.Implementations
{
    public class CompetenceService : ICompetenceService
    {
        private ICompetenceRepository _competenceRepository;

        public CompetenceService(ICompetenceRepository competenceRepository)
        {
            _competenceRepository = competenceRepository;
        }
        public async Task<ICollection<Competence>> GetAll()
        {
            return await _competenceRepository.GetAll();
        }
    }
}
