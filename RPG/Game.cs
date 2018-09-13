using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Game
    {
        Hero Deku;
        Map Lvl1;

        public Game()
        {
            Deku = new Hero(4, 4);
            Lvl1 = new Map();

            Lvl1.AddMovable(Deku);
        }

        public void Play()
        {
            string stop = "a";
            Lvl1.Draw();
            while (stop != "x")
               {
                stop = Console.ReadLine();                

                if (stop=="a") //move left
                {                   
                    Deku.MoveLeft();
                }
                else if (stop == "w") //move up
                {                   
                    Deku.MoveUp();
                }
                else if(stop == "d") //move right
                {
                    Deku.MoveRight();
                }
                else if(stop == "s")//move dwon
                {
                    Deku.MoveDown(); 
                }
                //rysowanie mapy
                Lvl1.Draw();

              
                Console.WriteLine(stop);                

               }
        }
    }
}
