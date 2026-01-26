namespace userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter your age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("your age is : " +age);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;

            Console.WriteLine("Hello " + name);


        }
    }
}
