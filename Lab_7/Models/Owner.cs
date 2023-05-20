namespace PPPI.Models
{
    public class Owner
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public string Age { get; set; } = "";

        public override string ToString()
        {
            return $"Name = {Name}, Surname = {Surname}, Age = {Age}";
        }
    }
}