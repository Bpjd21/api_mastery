﻿using System.Collections.Generic;
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
