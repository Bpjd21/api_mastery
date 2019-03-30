using api_mastery.Controllers;
using api_mastery.Models;
using api_mastery.Repositories;
using NSubstitute;
using System;
using System.Linq;
using Xunit;

namespace api_masteryTests
{
    public class DogBreedControllerTests
    {
        DogBreedController underTest;
        private IDogBreedRepository repo;

        public DogBreedControllerTests()
        {
            repo = Substitute.For<IDogBreedRepository>();
            underTest = new DogBreedController(repo);
        }

        [Fact]
        public void Post_Creates_New_DogBreed()
        {
            var dogBreed = new DogBreed();
            //var repo = Substitute.For<IDogBreedRepository>();
           // var underTest = new DogBreedController(repo);

            underTest.Post(dogBreed);

            repo.Received().Create(dogBreed);
        }

      
    }
}
