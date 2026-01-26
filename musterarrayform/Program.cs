namespace musterarrayform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;

                Console.WriteLine(x / y);
            }
            catch {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
