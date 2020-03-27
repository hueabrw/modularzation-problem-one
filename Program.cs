using System;

namespace modularzation_problem_one
{
    class Program
    {
        //Main method: Where the program logic is executed
        static void Main(string[] args)
        {
            Console.Clear();
            int num_one;
            int num_two;

            num_one = intakeFirstNumber();
            num_two = intakeSecondNumber();

            sum(num_one, num_two);
            multiply(num_one, num_two);
            endProgram();
        }
        //Method one: Takes in users first number
        public static int intakeFirstNumber(){
            System.Console.Write("Please enter your first number: ");
            string input = System.Console.ReadLine();

            int num_one = Convert.ToInt32(input);
            System.Console.WriteLine($"The number your entered is: {num_one}\n");

            Console.Write("press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            return num_one;
        }
        //Method two: Takes in users second number
        public static int intakeSecondNumber(){
            System.Console.Write("Please enter your second number: ");
            string input = System.Console.ReadLine();

            int num_two = Convert.ToInt32(input);
            System.Console.WriteLine($"The number your entered is: {num_two}\n");

            Console.Write("press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            return num_two;
        }
        //Method three: Adds the sum of the two numbers
        public static void sum(int num_one, int num_two){
            
            int sum = num_one + num_two;

            System.Console.WriteLine($"the sum of your two numbers is: {sum}\n");
        }
        //Method four: Multiplies the two numbers
        public static void multiply(int num_one, int num_two){
            
            int product = num_one * num_two;

            System.Console.WriteLine($"the product of your two numbers is: {product}\n");
        }
        //Method five: Ends the program
        public static void endProgram(){
            System.Console.WriteLine("the program has ended");
        }
    }
}
