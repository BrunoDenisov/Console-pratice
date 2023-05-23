using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice1
{
    public class Fuel
    {
        public float Kilometers { get; set; }

        public float Fuel100KM { get; set; }

        public virtual float calulation()
        {
            return (Kilometers * Fuel100KM / 100);
        }
    }
}
