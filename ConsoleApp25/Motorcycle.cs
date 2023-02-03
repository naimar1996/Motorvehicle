using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class Motorcycle : MotoredVehicle
    {
        public Motorcycle(string model, string make, int fueltanksize, int currentfuelamount, int fuelusedperkm) : base(model, make, fueltanksize, currentfuelamount, fuelusedperkm)
        {
        }
        public override void GetInfo()
        {
            Console.WriteLine("GetInfo");
        }
        public override void GetDetailedInfo()
        {
            Console.WriteLine(" GetDetailedInfo");


        }
    }
}
