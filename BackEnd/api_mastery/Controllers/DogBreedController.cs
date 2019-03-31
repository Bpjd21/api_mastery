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
    public class DogBreedController : ControllerBase
    {
        private IDogBreedRepository repo;

        public DogBreedController(IDogBreedRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DogBreed>> Get()
        {
            return repo.GetAll().ToArray();
        }

        [HttpPost]
        public void Post([FromBody] DogBreed dogBreed)
        {
            repo.Create(dogBreed);
        }

        
        [HttpPost]
        public ActionResult Delete(DogBreed dogBreed)
        {

            repo.Delete(dogBreed);
            return RedirectToAction("DogBreeds");
        }

        [HttpPost]
        public ActionResult Edit(DogBreed dogBreed)
        {
            repo.Edit(dogBreed);
            return RedirectToAction("DogBreeds/" + dogBreed.Id);
        }
    }
}

    }
}