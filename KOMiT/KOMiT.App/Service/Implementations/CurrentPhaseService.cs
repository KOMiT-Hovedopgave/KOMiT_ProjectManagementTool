using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using KOMiT.DataAccess.Repositories.Implementations;
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
        private EstimatedAndRealizedDaysDTO _estimatedAndRealizedDaysDTO;

        public CurrentPhaseService(ICurrentPhaseRepository currentPhaseRepository)
        {
            _currentPhaseRepository = currentPhaseRepository;
        }

        public async Task<CurrentPhase> GetDetailsById(int id)
        {
            return await _currentPhaseRepository.GetDetailsById(id);

        }

        //public async Task<EstimatedAndRealizedDaysDTO> CalculatorDTO(int id)
        //{
        //    var result = await _currentPhaseRepository.GetEstimatedAndRealizedData(id);
        //    double estimatedSubProjectDays = CalculateDateDays(result.EstimatedEndDate, result.EstimatedStartDate);
        //    double realizedSubProjectsDays = 0;

        //    if (result.RealizedDate.HasValue)
        //    {
        //         realizedSubProjectsDays = CalculateDateDays(result.RealizedDate.Value, result.EstimatedStartDate);
        //    }

           
        //    _estimatedAndRealizedDaysDTO = new EstimatedAndRealizedDaysDTO(estimatedSubProjectDays, realizedSubProjectsDays,);

         
        //}


        public double CalculateDateDays(DateTime endDate, DateTime startDate)
        {
            return (endDate - startDate).TotalDays;
        }
    }
}
