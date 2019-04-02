using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Interfaces
{
    public class Lawnmower : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Lawnmower Started");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Lawnmower Stopped");
            return true;
        }
    }
}
