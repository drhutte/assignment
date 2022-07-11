using Assignment.Models;

namespace Assignment.Repository.Interface
{
    public interface IRepository
    {
        void SaveAnimals(List<CaptiveAnimal> animals);
    }
}
