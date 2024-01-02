using System;

namespace ConsoleApplication1
{
    public class Car
    {
        public string Color = "red";

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
                    Console.WriteLine("\nThere is no such Tesla");
                }
            }
        }
    }
}
