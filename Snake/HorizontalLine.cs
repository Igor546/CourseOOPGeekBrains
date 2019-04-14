using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure // Горизонтальная линия наследуеться от фигуры
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbols)
        {
            pList = new List<Point>();       
            for (int x = xLeft; x <= xRight; x++) 
            {
                Point p = new Point(x, y, symbols);
                pList.Add(p);
            }
        }
    }
}
