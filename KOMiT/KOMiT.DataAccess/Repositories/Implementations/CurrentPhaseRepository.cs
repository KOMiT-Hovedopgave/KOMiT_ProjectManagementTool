using KOMiT.Core.Model;
using KOMiT.Core.Model.Enum;
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
                            //.Select(ssg => new StandardSubGoal
                            //(
                            //    ssg.Id,
                            //    ssg.Name,
                            //    ssg.Description,
                            //    ssg.StandardTasks
                            //        .Select(st => new StandardTask
                            //        (
                            //            st.Id,
                            //            st.Title,
                            //            st.Description
                            //        ))
                            //        .ToList()
                            //))
                            //.ToList()
                    )
                    //cp.CurrentSubGoals.Select(csg => new CurrentSubGoal()).ToList())
                ));

            return await result.SingleOrDefaultAsync();

        //        public int Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public Status Status { get; set; }
        //public DateTime EstimatedEndDate { get; set; }
        //public string? Comment { get; set; }
        //public DateTime? RealizedDate { get; set; }

        //public int? CurrentPhaseId { get; set; }
        //public CurrentPhase? CurrentPhase { get; set; }


        //public ICollection<CurrentTask>? CurrentTasks { get; } = new List<CurrentTask>();

        ////Join klasse bliver lavet her mellem CurrentSubGoal og ProjectMember
        //public ICollection<ProjectMember>? ProjectMembers { get; } = new List<ProjectMember>();
    }

    }
}
