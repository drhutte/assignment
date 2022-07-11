using Assignment.Controllers;
using Assignment.Models;
using Assignment.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests
{
    [TestClass]
    public class UnitTest
    {
        private IAnimalService _animalService;
        public UnitTest(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [TestMethod]
        public void TestCaptivate()
        {

            ZooController zoo = new(_animalService);

            var mammals = new List<Animal>();

            for(int i=0;i<4;i++)
            {
                _ = new Animal
                {
                    Name = $"animal{i}",
                    DateOfBirth = DateTime.Now.AddYears(i * -5),
                    NumberOfLegs = i,
                    Diet = new()
                    {
                        EatsFish = false,
                        EatsInsects = false,
                        EatsLeaves = true,
                        EatsMeat = true,
                        EatsVeg = true
                    }
                };


            }
            Assert.AreEqual(mammals.Count, zoo.Captivate(mammals).Count);
        }
    }
}
