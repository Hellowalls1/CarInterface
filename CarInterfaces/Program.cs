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

          //  Console.WriteLine("Please enter a speed.");
          //  string userSpeed = Console.ReadLine();
         //   int newSpeed = int.Parse(userSpeed);
            if (userAnswer == "sedan")
            {
                Console.WriteLine("Please enter a speed.");
                string userSpeed = Console.ReadLine();
                int newSpeed = int.Parse(userSpeed);

                Sedan s = new Sedan(newSpeed);
                Console.WriteLine($"The s sedan goes {s.Speed} mph and has {s.Wheels} wheels.");

            } else if (userAnswer == "truck")
            {
                Console.WriteLine("How much does your truck weigh? Enter a number between 1-900000.");
                string weight = Console.ReadLine();
                int truckWeight = int.Parse(weight);

                Console.WriteLine("Please enter a speed.");
                string userSpeed = Console.ReadLine();
                int newSpeed = int.Parse(userSpeed);

                Truck a = new Truck(newSpeed, truckWeight);
                Console.WriteLine($"Your truck has {a.Wheels} wheels, goes {a.Speed} mph.");

                Console.WriteLine("You see a vehicle driving slow in the left lane");
                Console.WriteLine("Do you want to slow down or speed up?");
                Console.WriteLine("Please enter one or the other....");
                string userDirection = Console.ReadLine();
                if (userDirection == "slow down")
                {
                    a.SlowDown();
                    Console.WriteLine($"Your new speed is {a.Speed}");
                } 



            }
            else
            {
                Console.WriteLine("That's not what the application asked. Goodbye!");
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
