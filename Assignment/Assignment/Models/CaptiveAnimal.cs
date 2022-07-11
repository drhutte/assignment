namespace Assignment.Models
{
    public class CaptiveAnimal:Animal
    {
        public DateTime Captivated { get; set; } = DateTime.Now;
    }
}
