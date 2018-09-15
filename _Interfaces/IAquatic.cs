using System;
using System.Collections.Generic;
using System.Text;

namespace AminalInterfaces._Interfaces
{
    public interface IAquatic
    {
        int MaximumDepth { get; }
        void swim();
        void land();
    }
}
