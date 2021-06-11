using System;

namespace MyCaves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = args.Length;
            int x = int.Parse(args[0]);
            int y = int.Parse(args[1]);
            int passos = int.Parse(args[2]);
            if (n == 3)
            {
                Console.WriteLine("Let's start");
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(passos);
            }
            else
            {
                Console.WriteLine("Only three arguments");
            }

        }
    }
}
