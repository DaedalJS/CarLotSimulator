using System;
using System.Net.Http;

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
            Console.WriteLine($"{CarLot.numberOfCars} cars on lot.");

            Car a = new Car(2020, "Ford", "Mustang", "cha kuh cha kuh cha k'PoW CLUG CLug clug ... clug ... clug  pshhhhhhh", "meeep meep", false);

            Console.WriteLine($"{CarLot.numberOfCars} cars on lot.");

            Car b = new Car()
            {
                Year = 2019,
                Make = "Dodge",
                Model = "Viper",
                EngineNoise = "VroOOOOOOOooom",
                HonkNoise = "AAAOOOOHHGAH",
                IsDrivable = true
            };

            Console.WriteLine($"{CarLot.numberOfCars} cars on lot.");

            Car c = new Car();
            c.Year = 2018;
            c.Make = "Tesla";
            c.Model = "Roadster";
            c.EngineNoise = "friend 1: is this thing cranked?";
            c.HonkNoise = "BeeP";
            c.IsDrivable = true;

            Console.WriteLine($"{CarLot.numberOfCars} cars on lot.");

            Console.WriteLine(a.Model);
            a.makeEngineNoise();
            a.makeHonkNoise();
            Console.WriteLine("\n");
            Console.WriteLine(a.Model);
            b.makeEngineNoise();
            b.makeHonkNoise();
            Console.WriteLine("\n");

            Console.WriteLine(a.Model);
            c.makeEngineNoise();
            c.makeHonkNoise();
            Console.WriteLine("\n");

            //Set the properties for each of the cars
            //Call each of the methods for each car

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
