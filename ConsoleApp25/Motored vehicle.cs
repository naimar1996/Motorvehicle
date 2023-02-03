using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
   public abstract  class MotoredVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public  int FuelTankSize{ get; set; }
        public int CurrentFuelAmount { get; set; }
        public int FuelUsedPerKm { get; set; }
        private string model;
        private string make;
        private int fueltanksize;
        private int currentfuelamount;
        private int fuelusedperkm;

        public MotoredVehicle(string model,string make,int fueltanksize,int currentfuelamount,int fuelusedperkm)
        {
            this.Model = model;
            this.Make = make;
            this.FuelTankSize = fueltanksize;
            this.CurrentFuelAmount = currentfuelamount;
            this.FuelUsedPerKm = fuelusedperkm;
        }
        public abstract void GetInfo();
        
        public abstract void GetDetailedInfo();
        
 
        
    }
}
