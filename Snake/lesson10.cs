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
            /// ----- Lesson 10 ----- /// "Змейка" в движении ///
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
            Snake snake = new Snake(p, 5, Direction.UP);                    // Размер и направление змейки
            snake.Draw();                                                   // Отрисовать змейку
            snake.Move();                                                   // Передвинуть змейку
            Thread.Sleep(300);                                              // Выполнить следующую команду с задержкой
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
