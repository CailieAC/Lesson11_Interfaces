using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Interfaces
{
    public class Car : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Car Started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Car Stopped");
            return true;
        }
    }
}
