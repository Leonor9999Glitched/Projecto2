using System;

namespace MyCaves
{
    public class World
    {
        private int x;
        private int y;

        Random rnd = new Random();

        public World(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show_World()
        {
            int [,] world = new int [this.x, this.y];

            for(int i = 0; i < this.x; i++)
            {
                for(int j = 0; j < this.y; j++)
                {
                    int t = rnd.Next(0, 2);
                    if(t == 0)
                    {
                        Console.Write(".");
                    }
                    else if(t == 1)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine("");
            }
        }

    }
}