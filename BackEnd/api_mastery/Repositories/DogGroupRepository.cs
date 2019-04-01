using System.Collections.Generic;
using System.Linq;
using api_mastery.Models;


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

