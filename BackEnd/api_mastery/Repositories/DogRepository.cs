using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;
using Microsoft.AspNetCore.Mvc;


namespace api_mastery.Repositories
{
    public class DogRepository : IDogRepository
    {   
        DogContext db;

        public DogRepository(DogContext db)
        {
            this.db = db;
        }

        public void Create(Dog dog)
        {
            db.Dogs.Add(dog);
            db.SaveChanges();
        }

        public IEnumerable<Dog> GetAll()
        {
            return db.Dogs.ToList();
        }
    }
}

