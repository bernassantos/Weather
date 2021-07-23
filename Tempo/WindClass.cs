using System.Collections.Generic;

namespace Tempo
{
    public class WindClass
    {
        public string Owner { get; set; }
        public string Country { get; set; }
        public List<WindClassification> Data { get; set; }
    }
}