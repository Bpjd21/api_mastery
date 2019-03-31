using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;

namespace api_mastery.Repositories
{
    public interface IDogBreedRepository
    {
        DogBreed GetByID(int id);
        void Create(DogBreed dogBreed);
        void Delete(DogBreed dogBreed);
        void Edit(DogBreed dogBreed);
        IEnumerable<DogBreed> GetAll();

    }
}
