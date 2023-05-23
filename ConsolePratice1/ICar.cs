using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice1
{
    public interface ICar
    {
        string Brand { get; set; }

        string Model { get; set; }

        string Color { get; set; }

        int Kilometrage { get; set; }

        int DoorNubmer { get; set; }
    }
}
