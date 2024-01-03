namespace ConsoleApplication1
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        protected int Wheels { get; }
        
        // Constructor 
        protected Vehicle(int wheels)
        {
            Wheels = wheels;
        }
        // Abstract methode
        public abstract void Honk();
    }
}