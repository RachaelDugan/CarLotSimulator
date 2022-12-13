using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Car car1 = new Car(2013, "Toyota", "Tacoma", "Vrooom", "Beep beep", true);
            Console.WriteLine($"Vehicle: {car1.Make} {car1.Model} {car1.Year}");
            Console.WriteLine("Engine and horn test:");
            car1.MakeEngineNoise("Vrooom");
            car1.MakeHonkNoise("Beep Beep");
            Console.WriteLine($"Is this car drivable? " + true);
            Console.WriteLine("This car is redy for sale!");
            Console.WriteLine();
            Console.WriteLine($"Starting with {CarLot.numberOfCars} car in the lot.");
            Console.WriteLine();

            Car car2 = new Car(2013, "Kia", "Sportage", "Zoom", "Honk Honk", true);
            Console.WriteLine($"Vehicle: {car2.Make} {car2.Model} {car2.Year}");
            Console.WriteLine("Engine and horn test:");
            car2.MakeEngineNoise("Zoom");
            car2.MakeHonkNoise("Honk Honk");
            Console.WriteLine($"Is this car drivable? " + true);
            Console.WriteLine("This car is redy for sale!");
            Console.WriteLine();
            Console.WriteLine($"we have {CarLot.numberOfCars} in the lot.");
            Console.WriteLine();

            Car car3 = new Car(1999, "Chevrolet", "Lumina", "Chuchuchcuchu", "Womp", false);
            Console.WriteLine($"Vehicle: {car3.Make} {car3.Model} {car3.Year}");
            Console.WriteLine("Engine and horn test:");
            car3.MakeEngineNoise("chuchuchuchuchuchu");
            car3.MakeHonkNoise("Womp");
            Console.WriteLine($"Is this car drivable? " + false);
            Console.WriteLine("This car is not redy for sale!");
            Console.WriteLine();
            Console.WriteLine($"We now have {CarLot.numberOfCars} but only 2 are ready for sale.");

           
            

            

            
            







            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
        
    }
}
