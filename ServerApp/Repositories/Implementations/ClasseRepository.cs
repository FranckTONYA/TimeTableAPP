using Microsoft.EntityFrameworkCore;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Repositories.Implementations
{
    public class ClasseRepository : Repository<Classe, int>, IClasseRepository
    {
        public ClasseRepository(bd_timetableContext context) : base(context)
        {

        }
        public override DbSet<Classe> Collections => context.Classe;

        public override Classe this[int id]
        {
            get
            {
                Classe obj = context.Classe.Include(f => f.IdfiliereNavigation).First(c => c.Idclasse == id);
                return obj;
            }
        }

        public override IEnumerable<Classe> List()
        {
            return context.Classe
                    .Include(f => f.IdfiliereNavigation)
                    .ToArray();
        }
    }
}
