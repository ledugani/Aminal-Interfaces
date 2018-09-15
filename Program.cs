using AminalInterfaces._Interfaces;
using System;

namespace AminalInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Seagull : IAquatic, IAmbulatory, IFlying
    {
        public int MaximumDepth => throw new NotImplementedException();

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void land()
        {
            throw new NotImplementedException();
        }

        public void run()
        {
            throw new NotImplementedException();
        }

        public void swim()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
            throw new NotImplementedException();
        }
    }
}
