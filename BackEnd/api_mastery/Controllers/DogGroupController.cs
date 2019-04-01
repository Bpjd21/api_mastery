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
    
    public class DogGroupController : Controller
    {
        IDogGroupRepository dogGroupRepo;

        public DogGroupController(IDogGroupRepository dogGroupRepo)
        {
            this.dogGroupRepo = dogGroupRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DogGroup>> Get()
        {
            return dogGroupRepo.GetAll().ToArray();
        }

        [HttpPost]
        public void Post([FromBody] DogGroup dogGroup)
        {
            dogGroupRepo.Create(dogGroup);
        }
    }
}
