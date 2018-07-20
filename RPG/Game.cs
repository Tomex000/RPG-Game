using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Game
    {       
        Hero Deku = new Hero();    
        Map Lvl1 = new Map();
        public void Play()
        {
            string stop = "a";
            
               while (stop != "x")
               {
                stop = Console.ReadLine();                

                if (stop=="a" || Console.ReadKey().Key != ConsoleKey.LeftArrow) //move left
                {                   
                    Deku.Moveleft();
                }
                if (stop == "w" || Console.ReadKey().Key != ConsoleKey.UpArrow) //move up
                {                   
                    Deku.MoveUp();
                }
                if (stop == "d" || Console.ReadKey().Key != ConsoleKey.RightArrow) //move right
                {
                    Deku.MoveRight();
                }
                if (stop == "s" || Console.ReadKey().Key != ConsoleKey.DownArrow)//move dwon
                {
                    Deku.MoveDown(); 
                }
                //rysowanie mapy
                Lvl1.Draw(Deku.PositionX, Deku.PositionY);

              
                Console.WriteLine(stop);                

               }
        }
    }
}
