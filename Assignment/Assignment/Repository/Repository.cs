using Assignment.Models;
using Assignment.Repository.Interface;

namespace Assignment.Repository
{
    public class Repository:IRepository
    {
        
        public void SaveAnimals(List<CaptiveAnimal> animals)
        {
            foreach(Animal animal in animals)
            {
                //save animal to CaptiveAnimal Table
                // use returned id to save Diet to AnimalDiet table
            }
        }
    }
}
