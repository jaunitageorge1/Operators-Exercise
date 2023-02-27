namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator. There's a catch though -- it only does division.");
            int a = 17; 
            int b = 4;

            int quotient = a / b;
            int remainder = a % b; 

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

        }
    }
}
