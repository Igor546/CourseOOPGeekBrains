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
            /// ----- Lesson 12 ----- /// "Змейка" с хорошим аппетитом ///
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

            /* Отрисовка еды на экране */
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            /* Управление змейкой */
            while (true)
            {
                // Генерация еды (если съела) или движение как обычно (если не чего есть)
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else snake.Move();

                Thread.Sleep(150);

                // Считывание с консоли нажатия
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            
            
        }
    }
}
