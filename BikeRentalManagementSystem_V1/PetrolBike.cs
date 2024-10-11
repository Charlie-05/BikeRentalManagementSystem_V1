using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class PetrolBike : Bike
    {
        public string FuelTankCapacity { get; set; }    
        public string EngineCapacity { get; set; }

        public PetrolBike(string bikeId, string brand, string model, decimal rentalPrice, string fuelTankCapacity, string engineCapacity) : base()
        {
            base.assignBrand(brand);
            base.assignId(bikeId);
            base.assignModel(model);
            base.assignPrice(rentalPrice);
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
            TotalBikes++;
        }
        public PetrolBike() : base() {
            TotalBikes++;
        }

        public void DisplayPetrolBikeInfo()
        {
            Console.WriteLine($"{base.ToString()}, FuelTankCapacity : {FuelTankCapacity} ,EngineCapacity : {EngineCapacity}");
        }

        public override string DisplayBikeInfo()
        {
            return $"{base.DisplayBikeInfo()} , FuelTankCapacity : {FuelTankCapacity} ,EngineCapacity : {EngineCapacity}";
        }
        public string returnId(PetrolBike pBike)
        {
           return  base.returnId(pBike);
        }
    }
}
