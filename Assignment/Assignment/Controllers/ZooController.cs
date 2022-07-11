using Assignment.Models;
using Assignment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZooController : ControllerBase
    {
        private readonly IAnimalService _mammalService;
        public ZooController(IAnimalService mammalService)
        {
            _mammalService = mammalService;
        }

        public string Index()
        {
            return "Zoo";
        }


        [HttpPost]
        [Route(("captivate"))]
        public List<CaptiveAnimal> Captivate(List<Animal> animals)
        {
            return _mammalService.Captivate(animals);
        }
    }
}
