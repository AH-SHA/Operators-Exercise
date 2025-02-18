namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("EXERCISE 1 - Operators:");
            Console.WriteLine();

            int a = 17;
            int b = 4;
        
                var sum = a + b; // Output is 21
                var subtract = a - b; // Output is 13
                var multiply = a * b;// Output is 61
                var quotient = a / b;// Output is 4
                var remainder = a % b;// Output is 1

            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {subtract}.");
            Console.WriteLine($"{a}*{b} is {multiply}.");
            Console.WriteLine($"{a}/{4} is {quotient} remainder {remainder}.");


            Console.WriteLine();
            Console.WriteLine("EXERCISE 2 - Operators - Calculate Area of Circle:");

            Console.WriteLine();
            Console.WriteLine("AREA of a CIRCLE:");
            Console.WriteLine();

            // Code to ask the user to provide input

            Console.WriteLine("Enter a number for the circle's RADIUS: ");

            //Create a variable called 'radius'
            //Converting user input to the 'double' variable type


            double radius = double.Parse(Console.ReadLine());




            //Calling the method 'CircleArea' and printing the method's result to the console
            Console.WriteLine($"The circle's area = {CircleArea(radius)}");





        }

        // Creating the method 'CircleArea' within the class of the project
        static double CircleArea(double radius)

        {

            // Coding the body of the method to calculate the area, using 'radius' as a parameter

            return (Math.PI) * Math.Pow(radius, 2);

        }






    }
}
