using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;

namespace ServerApp.Controllers
{
    [Route("api/classes")]
    public class ClasseController : Controller
    {
        private readonly IClasseRepository repository;

        public ClasseController(IClasseRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public Classe Get(int id) => repository[id];

        [HttpGet]
        public IEnumerable<Classe> List() => repository.List();
    }
}