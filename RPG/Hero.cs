using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Hero
    {
        public int PositionX{ get; set;}
        public int PositionY{ get; set;}

        public void Moveleft()
        {
            if (PositionX > 1)
            {
                PositionX--;
            }
            else
                PositionX = 1;
        }
        public void MoveRight()
        {
            if (PositionX < 10)
            {
                PositionX++;
            }
            else
                PositionX = 10;
        }
        public void MoveDown()
        {
            if (PositionY < 10)
            {
                PositionY++;
            }
            else
                PositionY = 10;
        }
        public void MoveUp()
        {
            if(PositionY > 1)
            {
                PositionY--;
            }
            else
            {
                PositionY = 1;
            }
        }
    }
}
