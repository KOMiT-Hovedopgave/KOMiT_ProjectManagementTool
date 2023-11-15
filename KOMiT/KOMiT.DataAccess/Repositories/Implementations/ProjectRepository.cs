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
          x.SubProjects.Select(sp => new SubProject(
              sp.Id,
              sp.Status,
              sp.EstimatedStartDate,
              sp.EstimatedEndDate,
              sp.Comment,
              sp.RealizedDate,
              sp.ProjectId,
              sp.Phases.Select(phase => new Phase(
                  phase.Id,
                  phase.Name,
                  phase.Description
              )).ToList()
          )).ToList()
      ));
        return await result.ToListAsync();
    }
}
