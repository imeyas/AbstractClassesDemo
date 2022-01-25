using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Console.WriteLine("\nFirst car driving in Abtract and Virtual modes:\n");
            var car1 = new Car()
            {
                HasTrunk = true,
                Make = "Tesla",
                Model = "S3XY",
                Year = 2023
            };

            car1.DriveAbstract();
            car1.DriveVirtual();

            Console.WriteLine("\n----------------------------------\n");

            var motorcycle1 = new Motorcycle()
            {
                HasSideCart = true,
                Make = "Harley-Davidson",
                Model = "Road King",
                Year = 2021
            };

            Console.WriteLine("\nFirst motorcyle driving in Abtract and Virtual modes:\n");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            Console.WriteLine("\n----------------------------------\n");

            Vehicle vehicle1 = new Car()
            {
                HasTrunk = true,
                Make = "Tesla",
                Model = "Model S",
                Year = 2017

            };

            Vehicle vehicle2 = new Car()
            {
                HasTrunk = true,
                Make = "Tesla",
                Model = "Model Y",
                Year = 2022
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine($"\nHere is a list of the vehicles currently available based on your type, make, model and year requirements:\n");

            foreach (var vehicle in vehicles)
            {
                if (vehicle == car1)
                {
                    Console.WriteLine($"\nThis {car1.Make} is part of the {car1.Model} release from the year {car1.Year}\n");
                }
                else if (vehicle == motorcycle1)
                {
                    Console.WriteLine($"\nThis {motorcycle1.Make} is part of the {motorcycle1.Model} release from the year {motorcycle1.Year}.\n");
                }
                else if (vehicle == vehicle1)
                {
                    Console.WriteLine($"\nThis {vehicle1.Make} is part of the {vehicle1.Model} release from the year {vehicle1.Year}\n");
                }
                else if (vehicle == vehicle2)
                {
                    Console.WriteLine($"\nThis {vehicle2.Make} is part of the {vehicle2.Model} release from the year {vehicle2.Year}\n");
                }
            }

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
