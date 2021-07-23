using System;
using System.Collections.Generic;

namespace Tempo
{
    public class Weather
    {
        public string Owner { get; set; }
        public string Country { get; set; }
        public List<Forecast> Data { get; set; }
        public int GlobalIdLocal { get; set; }
        public DateTime DataUpdate { get; set; }
        
    }
}