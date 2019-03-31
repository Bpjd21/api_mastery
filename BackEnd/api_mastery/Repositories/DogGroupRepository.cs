using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;
using Microsoft.AspNetCore.Mvc;


namespace api_mastery.Repositories
{
    public class DogGroupRepository : IDogGroupRepository
    {
        DogBreedContext db;

        public DogGroupRepository(DogBreedContext db)
        {
            this.db = db;
        }

        public void Create(DogGroup dogGroup)
        {
            db.DogGroups.Add(dogGroup);
            db.SaveChanges();
        }

        public IEnumerable<DogGroup> GetAll()
        {
            return db.DogGroups.ToList();
        }
    }
}

