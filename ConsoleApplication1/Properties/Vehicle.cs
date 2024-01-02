namespace ConsoleApplication1.Properties
{
    public class Vehicle
    {
        public string Brand { get; set; }
        protected int Wheels;

        public virtual void Honk()
        {
            System.Console.WriteLine("\nbeep, beep!");
        }
    }
}