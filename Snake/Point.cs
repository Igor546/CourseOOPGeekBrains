using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbols;

        /* Процедура отрисовки символа */
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbols);
        }

        /* Процедура перемещения символа */
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT) x = x - offset;
            if (direction == Direction.RIGHT) x = x + offset;
            if (direction == Direction.UP) y = y - offset;
            if (direction == Direction.DOWN) y = y + offset;
        }

        /* Процедура удаления символа */
        public void Clear()
        {
            symbols = ' ';
            Draw();
        }

        /* Функция конструктр */
        public Point(int _x, int _y, char _symbols)
        {
            x = _x;
            y = _y;
            symbols = _symbols;
        }

        /* Функция конструктр */
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbols = p.symbols;
        }

        /* Функция проверяет равенство координат */
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
