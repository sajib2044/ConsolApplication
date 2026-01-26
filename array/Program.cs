namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single dimentation array
            //int size = 5;
            //int[] ages = new int[size];

            //ages[0] = 1;
            //ages[1] = 2;
            //ages[2] = 3;
            //ages[3] = 4;
            //ages[4] = 5;

            //Console.WriteLine(ages[0]);

            //string[] names = new string[3];

            //names[0] = "sajib";
            //names[1] = "asad";
            //names[2] = "siam";

            //Console.WriteLine(names[1]);


            //string[] names = { "sajib", "asad","mithun"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            // string[] names = { "sajib", "ayon", "asad", "siam", "sujoy","diba" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            int[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            foreach (int id in ids) {
                Console.WriteLine(id);
            }


        }
    }
}
