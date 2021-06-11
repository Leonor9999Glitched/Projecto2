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
            //int repetição = 0;

            //Arrays para o mundo
            //int [,] world = new int [x,y];
            //int [,] newWorld = new int [x,y];
            //int [,] auxWorld = new int [x,y];

            //Definir se é Rock ou Ground
            Random rnd = new Random();
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
