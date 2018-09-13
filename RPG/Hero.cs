using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Hero : IMovable, IDrawable
    {
        

        public Hero()
        {
            posX = 0;
            posY = 0;
        }

        public Hero(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public Hero(int posXY)
            : this(posXY, posXY)
        { }

        // fields / members
        private char marker = 'O';
        private int posX;
        private int posY;

        // properties
        public char Marker
        {
            get { return marker; }
            set { marker = value; }
        }
        
        public int PositionX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PositionY
        {
            get { return posY; }
            set { posY = value; }
        }

        public void MoveLeft()
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
            if (PositionY > 1)
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
