

using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Hallo World in C#");
            System.Console.WriteLine("Math: " + 3 + 4);
            System.Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");
            
            // Commenting works as usual
            /*System.Console.WriteLine("Hallo World in C#");
               System.Console.WriteLine("Math: " + 3 + 4);
               System.Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");*/
            
            // Primitive data types
            int i = 3455;
            double i01 = 3453.443543;
            char x = 'y';
            string name = "j.f.";
            bool y = true;
            
            // Printout vars
            Console.WriteLine("All primitive data types in c#: integer: " + i + ", double: " + i01 + ", char: " + x + ", string: " + name + ", bool: " + y);
            

        }
    }
}