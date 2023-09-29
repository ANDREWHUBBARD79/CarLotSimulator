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
            var lot = new Carlot();
            

            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Installation 1
            var michaelsCar = new Car();
            michaelsCar.Make = "Ford";
            michaelsCar.Model = "Focus";
            michaelsCar.Year = 2013;
            michaelsCar.EngineNoise = "Vroom";
            michaelsCar.HonkNoise = "Beep";
            michaelsCar.IsDrivable = true;


            lot.Cars.Add(michaelsCar);


            //Installation 2
            var stevesCar = new Car()
            {

               Year = 2019,
               Make = "Tesla",
               Model = "Cyber Truck",
               EngineNoise = "...",
               HonkNoise = "vruuuuga",
               IsDrivable = false

            };

            //add stevesCar to the carlot
            lot.Cars.Add(stevesCar);


            var brettsCar = new Car(2013,"Honda","Civic","Vrrrooom","Vruuuga",true);


            lot.Cars.Add(brettsCar);
         

            //Call methods
            michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {Carlot.numberOfCars}");



         foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        
        }
    }
}
