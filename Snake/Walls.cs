using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        /// Данные ///
        List<Figure> wallList;

        /// Конструктор ///
        public Walls(int mapWidth, int mapHeight)
        {
            /* Создаем список фигур */
            wallList = new List<Figure>();
            /* Создание линии */
            HorizontalLine TopLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine BottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 2, '+');
            VerticalLine LeftLine = new VerticalLine(0, mapHeight - 2, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, mapHeight - 2, mapWidth - 2, '+');
            /* Отрисовка линии */
            wallList.Add(TopLine);
            wallList.Add(BottomLine);
            wallList.Add(LeftLine);
            wallList.Add(RightLine);
        }

        /// Функции ///
        /* Процедура рисования всех стен которые в списке wallList */
        public void Draw()
        {
            foreach (Figure fig in wallList)
            {
                fig.Draw();
            }
        }
        /* Функция возвращает столкнулась ли змейка со стенами */
        internal bool IsHit(Figure figure)
        {
            foreach (var fig in wallList)
            {
                if (fig.IsHit(figure)) return true;
            }
            return false;
        }
    }
}
