using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Hero
    {
        int x = 1, y = 1;

        public void Moveleft()
        {
            if (x > 1)
            {
                x = x - 1;
            }
            else
                x = 1;
        }
        public void MoveRight()
        {
            if (x < 10)
            {
                x = x + 1;
            }
            else
                x = 10;
        }
        public void MoveDown()
        {
            if (y < 10)
            {
                y = y + 1;
            }
            else
                y = 10;
        }
        public void MoveUp()
        {
            if(y>1)
            {
                y = y - 1;
            }
            else
            {
                y = 1;
            }
        }
    }
}
