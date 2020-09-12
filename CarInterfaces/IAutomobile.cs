using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterfaces
{
    interface IAutomobile
    {
       
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
}
