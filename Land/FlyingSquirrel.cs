using AminalInterfaces._Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AminalInterfaces.Land
{
    class FlyingSquirrel : IAmbulatory, IFlying
    {
        public void run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        public void fly()
        {
            Console.WriteLine("Animal is now flying");
        }

        public void land()
        {
            Console.WriteLine("Animal is now on the ground");
        }
    }
}
