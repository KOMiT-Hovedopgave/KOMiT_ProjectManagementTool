using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service
{
    public interface IProjectMemberService
    {
        Task AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, ProjectMember projectMember);
        Task<List<Employee>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id);
    }
}
