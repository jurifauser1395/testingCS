using System;

namespace ConsoleApplication1
{
    public class Car
    {
        private String Color = "red";
        private String Form;
        private int HP;


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