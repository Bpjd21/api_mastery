using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;
using api_mastery.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_mastery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private IDogRepository repo;

        public DogController(IDogRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get()
        {
            return repo.GetAll().ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Dog dog)
        {
            repo.Create(dog);
        }
    }
}