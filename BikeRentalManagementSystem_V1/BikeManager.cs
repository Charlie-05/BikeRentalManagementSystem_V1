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

            Bike bike = new Bike(BikeID, Brand, Model, RentalPrice) { };
            bike.assignId(BikeID);
            BikeList.Add(bike);
            Console.WriteLine("Bike Successfully added...");

        }

        public void ReadBikes()
        {
            if (BikeList.Count > 0)
            {
                foreach (Bike bike in BikeList)
                {
                    Console.WriteLine(bike.ToString());
                }
            }
            else
            {
                Console.WriteLine("No Bikes available.");
            }

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
