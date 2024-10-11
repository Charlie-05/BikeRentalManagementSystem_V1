using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class ElectricBike : Bike
    {
        public string BatteryCapacity { get; set; } 
        public string MotorPower { get; set; }

        public ElectricBike() : base()
        { }
        public void DisplayElectricBikeInfo()
        {
            Console.WriteLine($"{ base.ToString()},  BatteryCapacity : {BatteryCapacity} ,MotorPower : {MotorPower}");
        }

        public override string DisplayBikeInfo()
        {
            return $"{base.DisplayBikeInfo()} ,  BatteryCapacity : {BatteryCapacity} ,MotorPower : {MotorPower}";
        }
    }
}
