using System.Collections.Generic;

namespace ConsoleApp5
{
    public class ExchangeRates
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public Rates Rates { get; set; }
    }

    public class Rates
    {
        public float USD { get; set; }
        public float EUR { get; set; }
    }
}