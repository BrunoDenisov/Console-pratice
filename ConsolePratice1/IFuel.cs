using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice1
{
    public interface IFuel
    {
        float Kilometers { get; set; }

        float Fuel100KM { get; set; }

        float calulation();

    }
}
