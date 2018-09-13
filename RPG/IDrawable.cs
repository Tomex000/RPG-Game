using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public interface IDrawable
    {
        char Marker { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
    }
}
