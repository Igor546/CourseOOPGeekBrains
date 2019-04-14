using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure // Вертикальная линия наследуеться от фигуры
    {
        public VerticalLine(int yTop, int yBottom, int x, char symbols)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, symbols);
                pList.Add(p);
            }
        }
    }
} 