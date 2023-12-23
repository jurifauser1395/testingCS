


using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hallo World in C#");
            Console.WriteLine("Math: " + 3 + 4);
            Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");
            
            // Commenting works as usual
            /*System.Console.WriteLine("Hallo World in C#");
               System.Console.WriteLine("Math: " + 3 + 4);
               System.Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");*/
            
            // Primitive data types
            int i = 3455;
            int ii = 3;
            i = i + ii;
            long iii = 3400000000000000000;
            float l = 3.454343F;
            double i01 = 3453.443543D;
            char x = 'y';
            string name = "j.f.";
            bool y;
            
            if (i == 3455) 
            {
                y = false;
            }
            else
            {
                y = true;
            }
            
            // Printout vars
            Console.WriteLine("All primitive data types in c#: integer: " + i + ", float: " + l + ", double: " + i01 + ", char: " + x + ", string: " + name + ", bool: " + y);
            
            // Constants can't be overriden 
            /* Const int myNum = 15;
             myNum = 20; is will return an error*/
            
            // Declare more then one variable of the same time
            int z = 4, g = 3, a = 6;
            Console.WriteLine(z + g + a);
            
            // Methods for type conversion
            Console.WriteLine(Convert.ToString(y));

            // Try the ReadLine() method
            Console.WriteLine("Enter your name:");
            String enteredName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + enteredName + " how are you?");
            Console.WriteLine("");
            Console.WriteLine("Tell me your age: ");
            Console.WriteLine("");
            String age = Console.ReadLine();
            Console.WriteLine("Your age is: " + age);
        }
    }
}