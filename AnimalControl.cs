using AminalInterfaces._Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AminalInterfaces
{
    public class AnimalControl
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HourlyRate { get; set; }

        public void Capture(IAmbulatory animal)
        {
            // Logic to contain, sedate, and return any ground-based animal
        }
    }
}
