using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterfaces
{
    class Sedan : IAutomobile
    {
        

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }

        public Sedan(double speed)
        {
            Speed = speed;
           
            Wheels = 4;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

    }
}
