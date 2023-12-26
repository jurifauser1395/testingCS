


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
            System.Console.WriteLine("Hallo World in C#");
            System.Console.WriteLine("Math: " + 3 + 4);
            System.Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");
            
            // Primitive data types
            int i = 3455;
            int ii = 3;
            i = i + ii;
            long iii = 3400000000000000000;
            float l = 3.454343F;
            double i01 = 3453.443543D;
            char x = 'y';
            string name01 = "j.f.";
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
            Console.WriteLine("All primitive data types in c#: integer: " + i + ", float: " + l + ", double: " + i01 + ", char: " + x + ", string: " + name01 + ", bool: " + y);
            
            // Constants can't be overriden 
            /*Const int myNum = 15;
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
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);            
            
            // Trying modulo operation 
            Console.WriteLine("Enter a number between 0 - 100000: ");
            Console.WriteLine("");
            
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            
            if (enteredNumber % 2 == 0)
            {
                Console.WriteLine(enteredNumber +" is an even number!");
            }
            else
            {
               int xy = enteredNumber % 2;
                
                Console.WriteLine(enteredNumber + " is an odd number cause the residue is: " + xy);
                
            }
                        
            // Play with the Math Class
            Console.WriteLine("To figure out which number is bigger enter two numbers below.");
            
            double num01 = Convert.ToDouble(Console.ReadLine());
            double num02 = Convert.ToDouble(Console.ReadLine());

            double num03 = Math.Max(num01, num02);
            double num04 = Math.Min(num01, num02);
            Console.WriteLine(num03 + " is bigger than " + num04);
            
            // Try out the .Length sting methode
            Console.WriteLine("To figure out the length of a work enter it below");
            Console.WriteLine(" ");
            String enteredText = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Your entered text has " + enteredText.Length + " letters");
            Console.WriteLine("Your text will be displayed in upper case here: " + enteredText.ToUpper());
            
            // String interpolation
            String fName = "John";
            String lName = "Doe";
            String name = $"The name is: {fName} {lName}";
            int secondName = name.IndexOf("D");
            Console.WriteLine("The second Name is: " + name.Substring(secondName) + "\nAnd your first name is: " + fName);



        }
    }
}