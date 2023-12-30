

/*
using System;
using System.Linq;


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
            Console.WriteLine("Hallo World in C#");
            Console.WriteLine("Math: " + 3 + 4);
            Console.WriteLine("Math: " + (3 + 4) + " only works within parentheses");
            
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
            myNum = 20; is will return an error
            
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
            Console.WriteLine("\nEnter a number between 0 - 100000: ");
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
            Console.WriteLine("\nTo figure out which number is bigger enter two numbers below.");
            
            double num01 = Convert.ToDouble(Console.ReadLine());
            double num02 = Convert.ToDouble(Console.ReadLine());

            if (!(num01 == num02))
            {
                double num03 = Math.Max(num01, num02);
                double num04 = Math.Min(num01, num02);
                Console.WriteLine(num03 + " is bigger than " + num04);
            }

            // Try out the .Length sting methode
            Console.WriteLine("\nTo figure out the length of a text enter it below");
            Console.WriteLine(" ");
            String enteredText = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Your entered text has " + enteredText.Length + " characters");
            Console.WriteLine("Your text will be displayed in upper case here: " + enteredText.ToUpper() + "\n");
            
            // String interpolation
            String fName = "John";
            String lName = "Doe";
            String name = $"The name is: {fName} {lName}";
            int secondName = name.IndexOf("D");
            Console.WriteLine("The second Name is: " + name.Substring(secondName) + "\nAnd your first name is: " + fName + "\n");
            
            // Ternary Operator (shorthand if...Else)
            float length = 5.5F;

            if (length >= 5)
            {
                Console.WriteLine("Good!");
            } 
            else
            {
                Console.WriteLine("Bad!");
            }
            
            // shorthand
            String statement = (length >= 5) ? "\nGood!" : "\nBad!";
            Console.WriteLine(statement);
            
            // switch operator
            int letterLength = enteredText.Length;

            switch (letterLength)
            {
                case 1:
                    Console.WriteLine("One letter");
                    break;
                case 2:
                    Console.WriteLine("Two letters");
                    break;
                case 3:
                    Console.WriteLine("Three letters");
                    break;
                default:
                    Console.WriteLine("More then three letters");
                    break;
            }
            
            // Testing out while loops
            while (letterLength < 10)
            {
                Console.WriteLine("There are " + letterLength + " characters\n");
                letterLength++;
            }

            letterLength = 0;

            do
            {
                Console.WriteLine("\nThere are " + letterLength + " characters\n");
                letterLength++;
            } while (letterLength < 30);
            
            // Nested for loops
            for (int ixyz = 0; ixyz <= 10; ixyz++)
            {
                Console.WriteLine("\nThis is the " + ixyz + "th. loop:");
                
                for (int xyz = 0; xyz <= 10; xyz++)
                {
                    Console.WriteLine("This is the inner loop " + xyz);
                }
            }
            
            // Foreach Loop
            string[] vegetables = { "carrot", "tomato", "potato", "carrot" };

            foreach (string vegetCarr in vegetables)
            {
                Console.WriteLine("\n" + vegetCarr);
            }
            
            // Arrays
            int[] myNumbers = { 3, 5, 35, 345, 34, 2, 1, 75, 75, 425, 7, 0, 4 };
            Console.WriteLine(myNumbers[3]);
            myNumbers[3] = 4934560;
            Console.WriteLine(myNumbers[3]);

            for (int ix = 0; ix < vegetables.Length; ix++)
            {
                Console.WriteLine("\nI like this vegetable: " + vegetables[ix]);
            }
            
            // Sorting arrays
            int[] myNumbers01 = { 3, 5, 35, 345, 34, 2, 1, 75, 75, 425, 7, 0, 4 };
            for (int ixy = 0; ixy < myNumbers01.Length; ixy++)
            {
                Console.WriteLine("\nUnsorted array: " + myNumbers01[ixy]);
            }
            Array.Sort(myNumbers01);
            for (int ixy = 0; ixy < myNumbers01.Length; ixy++)
            {
                Console.WriteLine("\nNow the sorted array: " + myNumbers01[ixy]);
            }

            
            String sortedStringInARow = string.Join(" ", myNumbers01);
            Console.WriteLine("Sorted array in a row: " + sortedStringInARow);
            int largestValue = myNumbers01.Max();
            Console.WriteLine("Largest value in this array is : " + largestValue);
            
            // Looping through 2D arrays
            int[,] num = { { 3, 53, 3, 6 }, { 6, 3, 5, 7 } };
            for (int ib = 0; ib < num.GetLength(0); ib++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (ib == 0)
                    {
                        Console.WriteLine("\nTuple number " + j + " : (" + num[ib, j] + ", " + num[1, j] + ")");
                    }
                    else
                        break;
                }
                break;
            }

        }
    }
}*/