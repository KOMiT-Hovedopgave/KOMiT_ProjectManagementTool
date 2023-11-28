﻿using KOMiT.Core.Model;
using KOMiT.Core.Model.Enum;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class EmployeeRepository : IEmployeeRepository
{
    private DatabaseContext _context;
    public EmployeeRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Employee>> GetAll()
    {
        var result = _context.Employees.Select(x => new Employee(
          x.Id,
          x.Name,
          x.JobPosition,
          x.Email,
          x.Competences.Select(c => new Competence(
                c.Id,
                c.Title,
                c.Description,
                c.Experience
            )
          ).ToList()
      ));
        return await result.ToListAsync();
    }

    //public async Task<Employee> GetDetailsById(int id)
    //{
    //    var result = _context.Employees
    //        .Where(x => x.Id == id)
    //        .Select(e => new Employee
    //        (e.Id,
    //         e.Name,
    //         e.JobPosition,
    //         e.Email,
    //         e.Competences.Select(c => new Competence(
    //          c.Id,
    //          c.Title,
    //          c.Description,
    //          c.Experience
    //        )
    //      ).ToList()
    //  ));

    //    return await result.SingleOrDefaultAsync();
    //}
}


