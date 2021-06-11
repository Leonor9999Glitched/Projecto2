using System;

namespace MyCaves
{
    public class World
    {
        private int x;
        private int y;
        private int cantos_x;
        private int cantos_y;

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

        public int Verificarcantos_x()
        {
            //Ver se o mundo não sai dos limites
            //Se o x for inferior a zero
            if(cantos_x < 0)
            {
                //Devolverá o valor do limite
                cantos_x = this.x;
            }

            if(cantos_x > this.x)
            {
                //Se o valor for maior que o limite
                //Devolverá o valor zero, o inicio
                cantos_x = 0;
            }
            return cantos_x;
        }

        public int Verificarcantos_y()
        {
            //Ver se o mundo não sai dos limites
            //Se o x for inferior a zero
            if(cantos_y < 0)
            {
                //Devolverá o valor do limite
                cantos_y = this.y;
            }

            if(cantos_y > this.y)
            {
                //Se o valor for maior que o limite
                //Devolverá o valor zero, o inicio
                cantos_y = 0;
            }
            return cantos_y;
        }

    }
}