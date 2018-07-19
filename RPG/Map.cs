using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Map
    {
        int[,] tablica = new int[10,10];

        public void Draw(int Hx, int Hy)   // arg to pozycja bohatera
        {
            {
                int a, b = 0;
                for (a = 1; a <= 11; a++)
                {
                    for (b = 1; b <= 11; b++)

                    {
                        if (a == 1 || a == 11)
                        {

                            if (b >= 1 && b <= 11)
                            {
                                Console.Write("-");//krawedz gorna
                            }
                            else if (b == 1 || b == 11)
                            {
                                Console.Write("|");//krawedz boczna 
                            }
                        }
                        else if (b == 1 || b == 11)
                        {
                            Console.Write("x");///naroza
                        }
                        else if (a == Hy && b == Hx)
                        {
                            Console.Write("o");//bohater
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
