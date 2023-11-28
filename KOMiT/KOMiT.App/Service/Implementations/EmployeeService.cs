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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task CreateEmployee(Employee employee)
        {
            await _employeeRepository.CreateEmployee(employee);
        }
    }
}
