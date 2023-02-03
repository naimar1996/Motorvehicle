using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class Car : MotoredVehicle
    {
        public override void GetInfo()
        {
            Console.WriteLine("GetInfo");
        }
        public override void GetDetailedInfo()
        {
            Console.WriteLine("GetInfo");
        }
        public Car(string model, string make, int fueltanksize, int currentfuelamount, int fuelusedperkm) : base(model, make, fueltanksize, currentfuelamount, fuelusedperkm)
        {
        }

        public void GetGo(int km)

        {
            if (CurrentFuelAmount / FuelUsedPerKm >= km)

            {
                Console.WriteLine($"{km} - distance gone");

            }
            else
            {
                Console.WriteLine($"{km} - not enough fuel");
            }
        }
    }
}
        

