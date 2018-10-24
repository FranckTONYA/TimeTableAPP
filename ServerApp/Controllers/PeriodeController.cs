using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;

namespace ServerApp.Controllers
{
    [Route("api/periodes")]
    public class PeriodeController: Controller
    {
            private IPeriodeRepository repository;
            public PeriodeController(IPeriodeRepository repository)
            {
                this.repository = repository;
            }

            [HttpGet]
            public IEnumerable<Periode> List() => repository.List();
        
    }
}
