namespace PPPI.Models
{
    public class Characteristic
    {
        public string Torque { get; set; } = "";
        public string EngineCapacity { get; set; } = "";
        public string HP { get; set; } = "";

        public override string ToString()
        {
            return $"Torque = {Torque}, EngineCapacity = {EngineCapacity}, HP = {HP}";
        }
    }
}
