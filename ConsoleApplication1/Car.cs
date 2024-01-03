using ConsoleApplication1;

namespace ConsoleApplication1
{
    // Car class derived from Vehicle class
    public class Car : Vehicle
    {
        // Fields
        public string Form { get; set; }
        public string Color { get; set; }
        private int _hp;
        
        // Constructor
        public Car(int wheels, string color, string form, int hp) : base(wheels)
        {
            Color = color;
            Form = form;
            Hp = hp;
        }
        
        // Fields with properties 
        public int Hp
        {

            get => _hp;
            set
            {
                if (value is > 0 and < 1100)
                {
                    _hp = value;
                }
                else
                {
                    System.Console.WriteLine("\nThere is no such Tesla");
                }
            }
        }
        
        // Methods
        public override void Honk()
        {
            System.Console.WriteLine("\npeeeep, peeeep!");
        }

        public int GetNumberOfWheelsCar()
        {
            return Wheels;
        }
    }
}
