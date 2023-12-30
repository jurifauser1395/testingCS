using System;



namespace ConsoleApplication1
{
    class Program01
    {
        // Methods
        static int AddingTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static void ChildNames(String child1, String child2, String child3, String child4)
        {
            Console.WriteLine("\nMy second child's name is: " + child2);
        }
        // Overload method 
        static double AddingTwoNumbers(double a, double b)
        {
            return a + b;
        }
   
        static void Main(String[] args)
        {
            int methodOutputInt = AddingTwoNumbers(4, 8);
            double methodOutputDoub = AddingTwoNumbers(4.4, 8.8);
            Console.WriteLine("This is the output of the AddingTwoNumbersInt method: " + methodOutputInt);
            Console.WriteLine("This is the output of the AddingTwoNumbersDoub method: " + methodOutputDoub);
            ChildNames(child2: "Jens", child1: "Jan", child3: "Jessica", child4: "Jasmin");

            Wife julia = new Wife(25, "fit", 45, 1);
            julia.BodyType = "pregnant";
            Console.WriteLine("\nMy wife is " + julia.BodyType);
        }
        
    }
}