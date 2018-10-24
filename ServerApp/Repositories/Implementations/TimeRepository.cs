using Microsoft.EntityFrameworkCore;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Repositories.Implementations
{
    public class TimeRepository : Repository<Time, int>, ITimeRepository
    {
        public TimeRepository(bd_timetableContext context): base(context)
        {

        }
        public override DbSet<Time> Collections => context.Time;

        public override IEnumerable<Time> List()
        {
            return Collections
                .Include(p => p.IdprogrammeNavigation)
                .Include(p => p.IdprogrammeNavigation.EnseignantNavigation)
                .Include(P =>P.IdprogrammeNavigation.IdueNavigation)
                .Where(p => p.IdprogrammeNavigation.Semestre == 1)
                .Include(c => c.IdperiodeNavigation)
                .Include(j => j.IdjourNavigation)
                .Include(s => s.IdsalleNavigation)
                .Where(p => p.IdprogrammeNavigation.IdclasseNavigation.Idfiliere == 2)
                .Where(p => p.IdprogrammeNavigation.IdclasseNavigation.Codgrade == "L")
                .Where(p => p.IdprogrammeNavigation.IdclasseNavigation.Niveau == "3")
                .ToArray();
        }
    }
}
