using Assignment.Models;
using Assignment.Repository.Interface;
using Assignment.Services.Interfaces;
using AutoMapper;

namespace Assignment.Services
{
    public class AnimalService: IAnimalService
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repository;
        public AnimalService(IMapper mapper, IRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<CaptiveAnimal> Captivate(List<Animal> animals)
        {
            var captives = new List<CaptiveAnimal>();

            foreach (var animal in animals)
            {
                _mapper.Map<CaptiveAnimal>(animal);

                captives.Add(_mapper.Map<CaptiveAnimal>(animal));
            }
            _repository.SaveAnimals(captives);
            return captives;
        }
    }
}
