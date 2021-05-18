using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE:  Create a seperate class file called Car
            //DONE:  Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE:  Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE:  The methods should take one string parameter: the respective noise property


            //DONE:  Now that the Car class is created we can instanciate 3 new cars
            //DONE:  Set the properties for each of the cars
            //DONE:  Call each of the methods for each car


            //*************BONUS*************//

            CarLot carLot = new CarLot();



            //DONE: Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car myFord = new Car();
            myFord.Year = 2021;
            myFord.Make = "Ford";
            myFord.Model = "Excersion";
            myFord.EngineNoise = "Vroom!";
            myFord.HonkNoise = "Beep beep!";
            myFord.IsDriveable = true;

            myFord.MakeEngineNoise();
            myFord.MakeHonkNoise();

            carLot.Cars.Add(myFord);

            Car motorhome = new Car() { Year = 1971, Make = "Unger", Model = "Crown Commander", EngineNoise = "Rrrr", HonkNoise = "nothing", IsDriveable = false };
            motorhome.MakeEngineNoise();
            motorhome.MakeHonkNoise();

            carLot.Cars.Add(motorhome);

            Car myGT = new Car(1965, "Ford", "GT40", "Vroom vroom", "beep", true);

            myGT.MakeEngineNoise();
            myGT.MakeHonkNoise();

            carLot.Cars.Add(myGT);
            //*************BONUS X 2*************//

            //DONE:  Create a CarLot class
            //DONE:  It should have at least one property: a List of cars
            //DONE:  Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            int i = 1;

            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"Car# {i}:  {car.Year} , {car.Make} , {car.Model}");
                i++;
            }
        }
    }
}
