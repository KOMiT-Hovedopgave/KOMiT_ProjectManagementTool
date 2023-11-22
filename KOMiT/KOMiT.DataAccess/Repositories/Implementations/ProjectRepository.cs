using KOMiT.Core.Model;
using KOMiT.Core.Model.Enum;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class ProjectRepository : IProjectRepository
{
    private DatabaseContext _context;
    public ProjectRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Project>> GetAll()
    {
        var result = _context.Projects.Select(x => new Project(
          x.Id,
          x.Name,
          x.Description,
          x.ProjectType,
          x.Priority,
          x.Status,
          x.EstimatedStartDate,
          x.EstimatedEndDate,
          x.Comment,
          x.RealizedDate,
          x.CurrentPhases.Select(cp => new CurrentPhase(
              cp.Id,
              cp.Status,
              cp.EstimatedStartDate,
              cp.EstimatedEndDate,
              cp.Comment,
              cp.RealizedDate,
              cp.ProjectId,
              cp.StandardPhase.Id,
                  new StandardPhase(
                cp.StandardPhase.Id,
                cp.StandardPhase.Name,
                cp.StandardPhase.Description
            )
          )).ToList()
      ));
        return await result.ToListAsync();
    }

    public async Task<Project> GetDetailsById(int id)
    {
        var result = _context.Projects
            .Where(x => x.Id == id)
            .Select(p => new Project
            (p.Id,
             p.Name,
             p.Description,
             p.ProjectType,
             p.Priority,
             p.Status,
             p.EstimatedStartDate,
             p.EstimatedEndDate,
             p.Comment,
             p.RealizedDate,
             p.CurrentPhases.Select(cp => new CurrentPhase(
              cp.Id,
              cp.Status,
              cp.EstimatedStartDate,
              cp.EstimatedEndDate,
              cp.Comment,
              cp.RealizedDate,
              cp.ProjectId,
              cp.StandardPhase.Id,
                  new StandardPhase(
                cp.StandardPhase.Id,
                cp.StandardPhase.Name,
                cp.StandardPhase.Description
            )
          )).ToList()
      ));

        return await result.SingleOrDefaultAsync();
    }
}


