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
        private IDogBreedRepository dogBreedRepo;

        public DogBreedController(IDogBreedRepository dogBreedRepo)
        {
            this.dogBreedRepo = dogBreedRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DogBreed>> Get()
        {
            return dogBreedRepo.GetAll().ToArray();
        }

        [HttpDelete]
        public void Post([FromBody] DogBreed dogBreed)
        {
            dogBreedRepo.Create(dogBreed);
        }

        
        [HttpPost]
        public ActionResult Delete(DogBreed dogBreed)
        {

            dogBreedRepo.Delete(dogBreed);
            return RedirectToAction("DogBreeds");
        }

        [HttpPost]
        public ActionResult Edit(DogBreed dogBreed)
        {
            dogBreedRepo.Edit(dogBreed);
            return RedirectToAction("DogBreeds/" + dogBreed.Id);
        }
    }
}

