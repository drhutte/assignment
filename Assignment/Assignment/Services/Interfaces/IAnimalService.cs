using Assignment.Models;

namespace Assignment.Services.Interfaces
{
    public interface IAnimalService
    {
        List<CaptiveAnimal> Captivate(List<Animal> mammals);
    }
}
