using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class BikeManager
    {
        public List<Bike> BikeList;
        public BikeManager()
        {
            BikeList = new List<Bike>();
        }

        public void CreateBike()
        {
            Console.WriteLine("Enter Bike ID");
            string BikeID = (Console.ReadLine());
            Console.WriteLine("Enter Bike Brand");
            string Brand = Console.ReadLine();
            Console.WriteLine("Enter Bike Model");
            string Model = Console.ReadLine();
            Console.WriteLine("Enter Rental Price");
            decimal RentalPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bike Type ( E : Electric , P : Petrol)");
            string Type = (Console.ReadLine()).ToLower();
            if(Type == "e")
            {
                Console.WriteLine("Enter the battery capacity");
                string batteryCapacity = Console.ReadLine();
                Console.WriteLine("Enter the MotorPower");
                string motorpower = Console.ReadLine();

                ElectricBike eBike = new ElectricBike(BikeID , Brand , Model , RentalPrice , batteryCapacity ,motorpower);
                BikeList.Add(eBike);
                Console.WriteLine("Bike Successfully added...");
            }
            else if(Type == "p"){
                Console.WriteLine("Enter the FuelTank Capacity");
                string fuelTankCapacity = Console.ReadLine();
                Console.WriteLine("Enter the Engine Capacity");
                string engineCapacity = Console.ReadLine();

                PetrolBike pBike = new PetrolBike(BikeID, Brand, Model, RentalPrice, fuelTankCapacity, engineCapacity);
                BikeList.Add(pBike);
                Console.WriteLine("Bike Successfully added...");
            }
            else
            {
                Console.WriteLine("Invalid Bike Type");
            }
          

            //Bike bike = new Bike(BikeID, Brand, Model, RentalPrice) { };
            //bike.assignId(BikeID);

        }

        public void ReadBikes()
        {
            if (BikeList.Count > 0)
            {
                foreach (Bike bike in BikeList)
                {
                    Console.WriteLine(bike.DisplayBikeInfo());
                }
            }
            else
            {
                Console.WriteLine("No Bikes available.");
            }

        }

        public PetrolBike findBikeByIdPetrol(string Id)
        {
            var result = new PetrolBike();
            foreach (PetrolBike bike in BikeList)
            {
                var checkId = bike.returnId(bike);
                if (checkId == Id)
                {                   
                    return bike;
                }
            }
            return null;
        }
        public ElectricBike findBikeByIdElectric(string Id)
        {
            var result = new ElectricBike();
            foreach (ElectricBike bike in BikeList)
            {
                var checkId = bike.returnId(bike);
                if (checkId == Id)
                {
                    return bike;
                }
            }
            return null;
        }
        public Bike findBikeById(string Id)
        {
            var result = new Bike();
            foreach (Bike bike in BikeList)
            {
                var checkId = bike.returnId(bike);
                if (checkId == Id)
                {

                    return bike;
                }
            }
            return null;
        }

        public void UpdateBike()
        {
            Console.WriteLine("Enter Bike ID");
            string BikeID = (Console.ReadLine());
            var result = findBikeById(BikeID);
            if (result != null)
            {
                BikeList.Remove(result);
                Console.WriteLine("Enter Bike Brand");
                string Brand = Console.ReadLine();
                Console.WriteLine("Enter Bike Model");
                string Model = Console.ReadLine();
                Console.WriteLine("Enter Rental Price");
                decimal RentalPrice = decimal.Parse(Console.ReadLine());
                
                Bike bike = new Bike(BikeID, Brand, Model, RentalPrice) { };
                BikeList.Add(bike);
                Console.WriteLine("Bike Successfully updated...");
            }
            else
            {
                Console.WriteLine("Invalid ID...");
            }


        }

        public void DeleteBike()
        {
            Console.WriteLine("Enter Bike ID to delete");
            string BikeID = (Console.ReadLine());
            var result = findBikeById(BikeID);
            if (result != null)
            {
                BikeList.Remove(result);
                Console.WriteLine("Bike successfully deleted");
            }
            else
            {
                Console.WriteLine("Invalid ID...");
            }
        }

    }
}
