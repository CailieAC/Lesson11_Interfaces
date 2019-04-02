using System;

namespace Lesson11_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var lawnmower = new Lawnmower();

            car.Start();
            lawnmower.Stop();
        }
    }
}
