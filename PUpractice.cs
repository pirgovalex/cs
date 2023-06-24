using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp
{
    class Car{
    public string Brand { get; set; }
    public int Year { get; set; }  
        }
    class Program{
                static void Main(string[] args){
               
                List<Car> cars = new List<Car>();
                  for(int i=0;i<3;i++){
                    Car car = new Car();
                    Console.Write("Enter Brand ");
                    car.Brand=Console.ReadLine();

                    Console.Write("Enter Year ");
                    car.Year=int.Parse(Console.ReadLine());
                    cars.Add(car);
                  }
                  cars.Sort((x, y) => x.Brand.CompareTo(y.Brand));
                  Console.WriteLine("Car details: ");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Year: {car.Year}");
            }
    }

    }
}