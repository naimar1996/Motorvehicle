using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "Iron", 50, 26, 2);
            car.GetGo(13);
        }
    }
}
