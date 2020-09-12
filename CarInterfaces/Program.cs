using System;

namespace CarInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Sedan t = new Sedan(70);
            Truck a = new Truck(45, 500);

            Console.WriteLine($"The s sedan goes {s.Speed} mph and has {s.Wheels} wheels.");

            Console.WriteLine($"The t sedan goes {t.Speed} mph and has {t.Wheels} wheels.");

            Console.WriteLine($"The a truck has {a.Speed} wheels, goes {a.Wheels} mph.");


            s.SpeedUp();
            t.SpeedUp();
            a.SpeedUp();

            Console.WriteLine($"s new speed is {s.Speed}");
            Console.WriteLine($"a new speed is {a.Speed}");
            Console.WriteLine($"t new speed is {t.Speed}");
        }
    }
}
