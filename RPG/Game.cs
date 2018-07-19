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
        Map Lvl1;
        public void Play()
        {
            string stop = "a";
            
               while (stop != "x")
               {
                stop = Console.ReadLine();
                Console.WriteLine(stop);
                if(stop =="a")
                {
                    Deku.Moveleft();
                }
               }
        }
    }
}
