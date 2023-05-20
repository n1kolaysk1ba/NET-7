namespace PPPI.Models
{
    public class Car
    {
        public string Mark { get; set; } = "";
        public string Model { get; set; } = "";
        public string Serie { get; set; } = "";

        public override string ToString()
        {
            return $"Mark = {Mark}, Model = {Model}, Serie = {Serie}";
        }
    }
}
