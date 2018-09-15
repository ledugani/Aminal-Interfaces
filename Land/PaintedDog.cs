using AminalInterfaces._Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AminalInterfaces.Land
{
    public class PaintedDog : IAmbulatory
    {
        public void run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}
