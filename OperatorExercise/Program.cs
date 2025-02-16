namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


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
           

        }
        
    }
}
