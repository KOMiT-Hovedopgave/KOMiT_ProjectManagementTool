using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service
{
    public interface ICurrentPhaseService
    {
        Task<CurrentPhase> GetDetailsById(int id);
        Task<EstimatedAndRealizedDaysDTO> CalculatorEstimatedAndRealizedDaysDTO(int id);
    }
}
