using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();
            
            
            var carOne = new car();
            carOne.Year = 2020;
            carOne.Make = "Honda";
            carOne.Model = "Accord";
            carOne.EngineNoise = "vroom";
            carOne.HonkNoise = "beep";
            carOne.IsDrivable = true;
            lot.Cars.Add(carOne);

            var carTwo = new car()
            {
                Year = 2015,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "VAROOM",
                HonkNoise = "HONK",
                IsDrivable = true
            };
            lot.Cars.Add(carTwo);

            var carThree = new car(1995, "Buick", "Regal", "Put Put", "Hhhh", false);
            lot.Cars.Add(carThree);

            Console.WriteLine("Engine Noise");
            carOne.MakeEngineNoise();
            carTwo.MakeEngineNoise();
            carThree.MakeEngineNoise();
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Honk Noise");
            carOne.MakeHonkNoise();
            carTwo.MakeHonkNoise();
            carThree.MakeHonkNoise();
            Console.WriteLine("--------------------------------------");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, {car.Model}");
            }   
        }
    }
}
