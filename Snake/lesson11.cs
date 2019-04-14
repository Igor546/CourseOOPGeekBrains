using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ----- Lesson 11 ----- /// Управляемая "Змейка" ///
            /* Отрисовка Рамочки */
            Console.SetBufferSize(80, 25);                                  // Блокируем окошко

            HorizontalLine TopLine = new HorizontalLine(0, 78, 0, '+');     // Создание линии
            HorizontalLine BottomLine = new HorizontalLine(0, 78, 24, '+');  
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');       
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');

            TopLine.Draw();                                                 // Отрисовка линии
            BottomLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();

            /* Отрисовка змейки */
            Point p = new Point(2, 2, '*');                                 // Стартовая позиция хвоста
            Snake snake = new Snake(p, 5, Direction.RIGHT);                 // Размер и направление змейки
            snake.Draw();                                                   // Отрисовать змейку

            /* Управление змейкой */
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(150);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
