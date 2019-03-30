using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_mastery.Models;

namespace api_mastery.Repositories
{
    public interface IDogRepository
    {
        void Create(Dog dog);
            IEnumerable<Dog> GetAll();
    }
}
