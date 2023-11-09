using KOMiT.Core.Model;
using KOMiT.Core.Model.Enum;
using KOMiT.DataAccess.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories;

public class ProjectRepository
{
    private DatabaseContext _context;
    public ProjectRepository(DatabaseContext context) 
    { 
        _context = context;
    }

    //public async Task<ICollection<Project>> GetAll()
    //{
    //    return;
    //}

}
