using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice1
{
    public class Car:Vehicle
    {
       public Guid InventoryIdentificator { get; set; }

       public string Brand { get; set; }

        public virtual string VTCheck()
        {
            string type;
            Console.WriteLine("$Please enter the type of your vehicle\n");
            type = Console.ReadLine();
            if (type != "Car")
            {
                return ("Not supported yet");
            }
            else
            {
                return ("Please continue");
            }
        }

       public string Model { get; set; }

       public string Color { get; set; }

       public int Kilometrage {  get; set; }

       public Fuel Fuel { get; set; }

       public int DoorNubmer { get; set; }

    }
}
