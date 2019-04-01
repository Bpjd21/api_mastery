using api_mastery.Models;
using System.Collections.Generic;

namespace api_mastery.Repositories
{
        public interface IDogGroupRepository
        {
            void Create(DogGroup dogGroup);
            IEnumerable<DogGroup> GetAll();
        }
}
