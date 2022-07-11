namespace Assignment.Models
{
    public class Animal
    {
        public int NumberOfLegs { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Diet Diet { get; set; }

    }

    public class Diet
    {
        public bool EatsMeat { get; set; }
        public bool EatsFish { get; set; }
        public bool EatsLeaves { get; set; }
        public bool EatsVeg { get; set; }
        public bool EatsInsects { get; set; }
    }
}
