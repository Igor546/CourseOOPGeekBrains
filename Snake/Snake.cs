using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        /// Даннные ///
        Direction direction;           // Направление в котором двигаеться змейка
        int speedMove = 100;

        /// Методы ///
        /* Функция построения змейки */
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;           // Переменная направления движения
            pList = new List<Point>();        // Создаем List точек
            for (int i = 0; i < lenght; i++)  // Создаем список точек из которых состоит змейка
            {
                Point p = new Point(tail);    // Новая точка
                p.Move(i, direction);         // Сдвигаем точку
                pList.Add(p);                 // Добавляем точку
            }
        }

        /* Функция движения змейки на один символ */
        internal void Move()
        {
            Point tail = pList.First();      // Точке tail присвайваем точку хвоста (первого элемента в списке)
            pList.Remove(tail);              // Удаляем точку tail (первый элемент в списке)
            Point head = GetNextPoint();     // Высчитываем точку новой головы (следующюю точку после старой головы)
            pList.Add(head);                 // Добавляем новую голову в конец списка

            tail.Clear();
            head.Draw();
            Thread.Sleep(speedMove);
        }

        /* Функция возвращаем следующую точку */
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        /* Функция съела ли змейка еду*/
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbols = head.symbols;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        /* Обработка нажатий в ходе игры */
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow) direction = Direction.UP;
            if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
            if (key == ConsoleKey.PageUp) speedMove = speedMove + 30;
            if (key == ConsoleKey.PageDown) speedMove = speedMove - 30;
        }

        /* Функция возвращает столкнулась ли змейка с хвостом */
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i])) return true;
            }
            return false;
        }
    }
}
