using System;

namespace MyCaves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel da dimensão dos argumentos
            int n = args.Length;

            //Variaveis que gurdam a informação dos argumentos
            int x = int.Parse(args[0]);
            int y = int.Parse(args[1]);
            int passos = int.Parse(args[2]);

            if (n == 3)
            {
                Console.WriteLine("Let's start");
                World bigWorld = new World(x, y);
                bigWorld.Show_World();
            }
            else
            {
                Console.WriteLine("Only three arguments");
            }

        }
    }
}
