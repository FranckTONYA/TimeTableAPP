using Microsoft.EntityFrameworkCore;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Repositories.Implementations
{
    public class ProgrammeRepository : Repository<Programme, int>, IProgrammeRepository
    {
        public ProgrammeRepository(bd_timetableContext context): base(context)
        {

        }
        public override DbSet<Programme> Collections => context.Programme;
    }
}
