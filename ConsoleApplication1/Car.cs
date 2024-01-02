using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    // Car class derived from Vehicle class
    public class Car : Vehicle
    {
        public string Color;

        public string Form { get; set; }

        private int _hp;
        
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

        public override void Honk()
        {
            System.Console.WriteLine("\npeeeep, peeeep!");
        }
    }
}
