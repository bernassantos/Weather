using System.Collections.Generic;

namespace Tempo
{
    public class WeatherType
    {
        public string Owner { get; set; }
        public string Country { get; set; }
        public List<WheaterTypeData> Data { get; set; }
    }
}