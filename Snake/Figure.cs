using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList; // protected (модификатор доступа) - будет видна у наследников

        /* Функция рисования фигуры (фигура это список точек) */
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        /* Функция возвращает столкнулась ли змейка со стенами */
        internal bool IsHit(Figure figure)
        {
            foreach (var fig in pList)
            {
                if (figure.IsHit(fig)) return true;
            }
            return false;
        }

        /* Функция возвращает столкнулась ли змейка со стенами */
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }
}
