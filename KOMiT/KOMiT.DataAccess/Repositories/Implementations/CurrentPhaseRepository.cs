using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.DataAccess.Repositories.Implementations
{
    public class CurrentPhaseRepository : ICurrentPhaseRepository
    {
        private DatabaseContext _context;
        public CurrentPhaseRepository(DatabaseContext context)
        {
            _context = context;
        }

        //public async Task<CurrentPhase> GetDetailsById(int id)
        //{
        //    var result = _context.CurrentPhases.Where(x => x.Id == id)
        //        .Select(cp => new CurrentPhase
        //        (cp.Id, cp.Status, cp.EstimatedStartDate, cp.EstimatedEndDate, cp.Comment, cp.RealizedDate, cp.StandardPhaseId,
        //           new StandardPhase(cp.StandardPhase.Id, cp.StandardPhase.Name, cp.StandardPhase.Description,
        //           cp.StandardPhase.StandardSubGoals.Select(ssg => new StandardSubGoal(ssg.Id, ssg.Name, ssg.Description, ssg.StandardTasks.Select(st => new StandardTask(st.Id, st.Title, st.Description))).Single();
        //}
        public async Task<CurrentPhase> GetDetailsById(int id)
        {
            var result = _context.CurrentPhases
                .Where(x => x.Id == id)
                .Select(cp => new CurrentPhase
                (
                    cp.Id,
                    cp.Status,
                    cp.EstimatedStartDate,
                    cp.EstimatedEndDate,
                    cp.Comment,
                    cp.RealizedDate,
                    cp.ProjectId,
                    cp.StandardPhaseId,             
                    new StandardPhase
                    (
                        cp.StandardPhase.Id,
                        cp.StandardPhase.Name,
                        cp.StandardPhase.Description,
                        cp.StandardPhase.StandardSubGoals
                            .Select(ssg => new StandardSubGoal
                            (
                                ssg.Id,
                                ssg.Name,
                                ssg.Description,
                                ssg.StandardTasks
                                    .Select(st => new StandardTask
                                    (
                                        st.Id,
                                        st.Title,
                                        st.Description
                                    ))
                                    .ToList()
                            ))
                            .ToList()
                    )
                    //cp.CurrentSubGoals.Select
                ));

            return await result.SingleOrDefaultAsync();
        }

    }
}
