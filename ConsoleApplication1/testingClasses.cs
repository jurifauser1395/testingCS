using System;
using ConsoleApplication1.Properties;


namespace ConsoleApplication1
{
    internal static class Program01
    {
        // Methods
        private static int AddingTwoNumbers(int a, int b)
        {
            return a + b;
        }

        private static void ChildNames(string child1, string child2, string child3, string child4)
        {
            Console.WriteLine("\nMy second child's name is: " + child2 + child1 + child3 + child4);
        }
        // Overload method 
        private static double AddingTwoNumbers(double a, double b)
        {
            return a + b;
        }

        private static void Main()
        {
            var methodOutputInt = AddingTwoNumbers(4, 8);
            var methodOutputDouble = AddingTwoNumbers(4.4, 8.8);
            Console.WriteLine("This is the output of the AddingTwoNumbersInt method: " + methodOutputInt);
            Console.WriteLine("This is the output of the AddingTwoNumbersDouble method: " + methodOutputDouble);
            ChildNames(child2: "Jens", child1: "Jan", child3: "Jessica", child4: "Jasmin");

            var julia = new Wife(25, "fit", 45, 1)
            {
                BodyType = "fit"
            };
            Console.WriteLine("\nMy wife is " + julia.BodyType + "\n");
            
            // Testing get and set properties, get, set and object initializers 
            var dailyCar = new Car
            {
                Color = "white",
                Hp = 1,
                Form = "slick",
                Brand = "Tesla"
            };
            var horsePower = dailyCar.Hp = 700;
            Console.WriteLine("MY daily Car is a " + dailyCar.Brand + ", it has a " + dailyCar.Form + " form, " + horsePower + "hp and a nice " + dailyCar.Color + " color!");
            
            // Polymorphism 
            Vehicle lada = new Vehicle();
            Vehicle vw = new Car();
            Vehicle honda = new MotorCycle();

            lada.Honk();
            vw.Honk();
            honda.Honk();
        }
    }
}