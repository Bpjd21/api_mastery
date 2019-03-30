using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;
using Microsoft.AspNetCore.Mvc;


namespace api_mastery.Repositories
{
    public class DogBreedRepository : IDogBreedRepository
    {   
        DogBreedContext db;

        public DogBreedRepository(DogBreedContext db)
        {
            this.db = db;
        }

        public void Create(DogBreed dogBreed)
        {
            db.DogBreeds.Add(dogBreed);
            db.SaveChanges();
        }

        public IEnumerable<DogBreed> GetAll()
        {
            return db.DogBreeds.ToList();
        }
    }
}

