using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_mastery.Models
{
    public class Dog
    {
        public int ID { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
        public string BreedInfo { get; set; }
    }
}
