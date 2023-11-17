using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories
{
    public interface ICurrentPhaseRepository
    {
        Task<CurrentPhase> GetDetailsById(int id);
    }
}
