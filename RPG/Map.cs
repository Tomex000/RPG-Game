using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Wall : IDrawable
    {
        public Wall(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        // fields / members
        private char marker = 'X';
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
    }

    public class Map
    {
        List<IDrawable> MapObjs { get; set; }

        public Map()
        {
            MapObjs = new List<IDrawable>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                        MapObjs.Add(new Wall(i, j));
                }
            }
        }

        public void AddMovable(IDrawable drawable)
        {
            MapObjs.Add(drawable);
        }

        public void Draw()   // arg to pozycja bohatera
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var somethingToDraw = MapObjs.Where(x => x.PositionX == i && x.PositionY == j).FirstOrDefault();//linq

                    if (somethingToDraw != null)
                        Console.Write(somethingToDraw.Marker);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
