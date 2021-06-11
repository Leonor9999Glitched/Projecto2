using System;

namespace MyCaves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = args.Length;
           if (n == 3)
            {
                Console.WriteLine("Let's start");
            }
            else
            {
                Console.WriteLine("Only three arguments");
            }

        }
    }
}
