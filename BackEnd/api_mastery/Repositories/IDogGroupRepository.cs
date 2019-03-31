using api_mastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_mastery.Repositories
{
        public interface IDogGroupRepository
        {
            void Create(DogGroup dogGroup);
            IEnumerable<DogGroup> GetAll();
        }
}
