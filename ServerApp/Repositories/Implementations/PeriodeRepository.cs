using Microsoft.EntityFrameworkCore;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Repositories.Implementations
{
    public class PeriodeRepository : Repository<Periode, int>, IPeriodeRepository
    {
        public PeriodeRepository(bd_timetableContext context) : base(context) { }

        public override DbSet<Periode> Collections => context.Periode;

        
    }
}
