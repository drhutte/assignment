using AutoMapper;
namespace Assignment.Models
{
    public class AnimalProfile:Profile
    {
        public AnimalProfile()
        {
            CreateMap<Animal, CaptiveAnimal>()
                .ForMember(x => x.Name, y => y.MapFrom(y => y.Name))
                .ForMember(x => x.NumberOfLegs, y => y.MapFrom(y => y.NumberOfLegs))
                .ForMember(x => x.DateOfBirth, y => y.MapFrom(y => y.DateOfBirth))
                .ForMember(x => x.Diet, y => y.MapFrom(y => y.Diet));

        }
    }
}
