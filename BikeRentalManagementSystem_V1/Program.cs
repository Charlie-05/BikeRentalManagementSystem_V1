using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bike bike1 = new Bike("BIKE_001", "YAMAHA", " mt - 15", 10.00M) { };
            Menu();
            Console.ReadLine(); 

        }

        public static void Menu()
        {
            BikeManager manager = new BikeManager();
            while (true)
            {
                Console.WriteLine("Bike Rental management System");
                Console.WriteLine("1. Add New Bike");
                Console.WriteLine("2. Read All Bikes");
                Console.WriteLine("3. Update A Bike");
                Console.WriteLine("4. Delete A bike");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option : ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        manager.CreateBike();
                        break;
                    case "2":
                        manager.ReadBikes();
                        break;
                    case "3":
                        manager.UpdateBike();
                        break;
                    case "4":
                        manager.DeleteBike();
                        break;
                    case "5":
                        Console.WriteLine("Thank You...");
                        return;
                    default:
                        Console.Clear();
                        Menu();
                        break;

                }
            }
        }
    }
}
