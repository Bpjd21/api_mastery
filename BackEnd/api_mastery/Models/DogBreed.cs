using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_mastery.Models
{
    public class DogBreed
    {
        public int Id { get; set; }
        public string DogBreedName { get; set; }
        public string DogBreedImg { get; set; }

        public int GroupId {get; set;}
    }
}
