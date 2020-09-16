using System;

namespace CarInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome  to Car Interfaces!");
            Console.WriteLine("Please select a sedan or truck.");

            string userAnswer = Console.ReadLine();

            Console.WriteLine("Please enter a speed.");
            string userSpeed = Console.ReadLine();
            int newSpeed = int.Parse(userSpeed);

            if (userAnswer == "sedan")
            {
            Sedan s = new Sedan(newSpeed);
            Console.WriteLine($"The s sedan goes {s.Speed} mph and has {s.Wheels} wheels.");

            } else
            {
            Truck a = new Truck(newSpeed, 500);
            Console.WriteLine($"The a truck has {a.Speed} wheels, goes {a.Wheels} mph.");

            }
           


            



           // s.SpeedUp();
           // t.SpeedUp();
          //  a.SpeedUp();

          //  Console.WriteLine($"s new speed is {s.Speed}");
          //  Console.WriteLine($"a new speed is {a.Speed}");
          //  Console.WriteLine($"t new speed is {t.Speed}");
        }
    }
}
