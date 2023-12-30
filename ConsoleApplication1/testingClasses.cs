using System;

namespace ConsoleApplication1
{
    class Program01
    {
        static int AddingTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static void ChildNames(String child1, String child2, String child3, String child4)
        {
            Console.WriteLine("\nMy second child's name is: " + child2);
        }
        
        static void Main(String[] args)
        {
            int methodOutput = AddingTwoNumbers(4, 8);
            Console.WriteLine("This is the output of the AddingTwoNumbers method: " + methodOutput);
            ChildNames(child2: "Jens", child1: "Jan", child3: "Jessica", child4: "Jasmin");
        }
    }
}