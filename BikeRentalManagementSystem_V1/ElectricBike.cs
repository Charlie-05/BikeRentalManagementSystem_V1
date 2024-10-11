using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class ElectricBike : Bike
    {
        public string BatteryCapacity { get; set; } 
        public string MotorPower { get; set; }

        public ElectricBike(string bikeId, string brand, string model, decimal rentalPrice, string batteryCapacity , string motorpower) : base()
        {   base.assignBrand(brand);
            base.assignId(bikeId);
            base.assignModel(model);
            base.assignPrice(rentalPrice);
            BatteryCapacity = batteryCapacity;
            MotorPower = motorpower;
            TotalBikes++;
        }

        public ElectricBike() : base() {
            TotalBikes++;
        }
        public void DisplayElectricBikeInfo()
        {
            Console.WriteLine($"{ base.ToString()},  BatteryCapacity : {BatteryCapacity} ,MotorPower : {MotorPower}");
        }

        public override string DisplayBikeInfo()
        {
            return $"{base.DisplayBikeInfo()} ,  BatteryCapacity : {BatteryCapacity} ,MotorPower : {MotorPower}";
        }

        public string returnId(ElectricBike eBike)
        {
            return base.returnId(eBike);
        }
    }
}
