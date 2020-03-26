using System;

namespace modularzation_problem_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_one;
            int num_two;

            num_one = intakeFirstNumber();
            num_two = intakeSecondNumber();

            sum(num_one, num_two);
            multiply(num_one, num_two);
            endProgram();
        }
        
        public static int intakeFirstNumber(){
            System.Console.Write("Please enter your first number: ");
            string input = System.Console.ReadLine();
            int num_one = Convert.ToInt32(input);
            System.Console.WriteLine($"The number your entered is: {num_one}\n");

            return num_one;
        }
        public static int intakeSecondNumber(){
            System.Console.Write("Please enter your second number: ");
            string input = System.Console.ReadLine();
            int num_two = Convert.ToInt32(input);
            System.Console.WriteLine($"The number your entered is: {num_two}\n");

            return num_two;
        }
        public static void sum(int num_one, int num_two){
            
            int sum = num_one + num_two;

            System.Console.WriteLine($"the sum of your two numbers is: {sum}\n");
        }
        public static void multiply(int num_one, int num_two){
            
            int product = num_one * num_two;

            System.Console.WriteLine($"the product of your two numbers is: {product}\n");
        }
        public static void endProgram(){
            System.Console.WriteLine("the program has ended");
        }
    }
}
