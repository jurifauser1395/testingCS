
using System;

namespace ConsoleApplication1.Properties
{
    public class Vehicle
    {
        public string Brand { get; set; }
        protected int Wheels = 4;

        public void Honk()
        {
            Console.WriteLine("beep, beep!");
        }
    }
}