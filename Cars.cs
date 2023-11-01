using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Cars
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int ProducedYear { get; set; }

        public Cars(string name,string colour,int producedYear)
        {
            Name = name;
            Colour = colour;
            ProducedYear = producedYear;
        }

        public override string ToString()
        {
            return $"{Name} {Colour} {ProducedYear}";
        }
    }
}
