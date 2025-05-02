namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;

                Console.WriteLine("Enter 1st number");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Entered number is {0}", a);
                Console.WriteLine("Enter 2nd number");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Entered number is {0}", b);
                double c = a / b;
                Console.WriteLine("The answer is {0}", c);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input Only integer");
            }
            catch (DividedbyzeroException ex)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

        }
    }
}
