using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerApp.entity;
using ServerApp.Repositories.Contracts;

namespace ServerApp.Controllers
{
    [Route("api/times")]
    public class TimeController : Controller
    {
        private ITimeRepository repository;
        public TimeController(ITimeRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Time> List() => repository.List();
    }
}