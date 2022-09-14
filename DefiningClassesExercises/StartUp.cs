using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double engineSpeed = double.Parse(input[1]);
                double enginePower = double.Parse(input[2]);
                double carWeigth = double.Parse(input[3]);
                string cargoType = input[4];
                List<Tires> tires = new List<Tires>();
                for (int j = 5; j <= 12; j+=2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j+1]);
                    Tires tire = new Tires(tireAge,tirePressure);
                    tires.Add(tire);

                }
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, carWeigth);
                Car car = new Car(name, engine, cargo, tires);

                list.Add(car);
            }
            string command = Console.ReadLine();
            if (command=="fragile")
            {
                List<Car> cars = list.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
                foreach (var item in cars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                List<Car> cars = list.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power>250).ToList();
                foreach (var item in cars)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }

    }
}

