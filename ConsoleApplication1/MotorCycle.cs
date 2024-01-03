using System;

namespace ConsoleApplication1
{
    public class MotorCycle : Vehicle

    {
        public MotorCycle(int wheels) : base(wheels)
        {
        } 
        public override void Honk()
        {
            System.Console.WriteLine("\nbrrr, brrr!");
        }

        public void GetNumberOfWheelsMCycle()
        {
            Console.WriteLine($"{Wheels}");
        }
    }
}