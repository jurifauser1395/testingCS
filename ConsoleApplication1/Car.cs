using System;

namespace ConsoleApplication1
{
    public class Car
    {
        public String Color;
        public String Form;
        public int HP;


        public string Color1
        {
            get => Color;
            set => Color = value;
        }

        public string Form1
        {
            get => Form;
            set => Form = value;
        }

        public int Hp
        {
            get => HP;
            set => HP = value;
        }
    }
}