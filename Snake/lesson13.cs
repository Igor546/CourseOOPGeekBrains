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
        static void Main()
        {
            /// ----- Lesson 13  ----- /// Класс "Препятствия". Полиморфизм.    ///
            /// ----- Lesson 14  ----- /// Приключенческий боевик. "Добыть еду. ///
            /* Отрисовка Рамочки */
            Console.Clear();
            Console.SetBufferSize(80, 25);                                  // Блокируем окошко

            /* Создание стен */
            Walls walls = new Walls(80, 23);
            walls.Draw();

            /* Отрисовка змейки */
            Point p = new Point(2, 2, '*');                                 // Стартовая позиция хвоста
            Snake snake = new Snake(p, 5, Direction.RIGHT);                 // Размер и направление змейки
            snake.Draw();                                                   // Отрисовать змейку

            /* Отрисовка еды на экране */
            FoodCreator foodCreator = new FoodCreator(80, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            /* Управление змейкой */
            while (true)
            {
                // Препятствия и границы (выход из цикла если удар об стену или хвост)
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.SetCursorPosition(2, 23);
                    Console.WriteLine("GAME OVER [Новая игра - нажми Enter]");
                    break;
                }
                // Генерация еды (если съела) или движение как обычно (если не чего есть)
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.SetCursorPosition(2, 23);
                    Console.WriteLine(foodCreator.countNewEat);
                } else snake.Move();

                // Считывание с консоли нажатия
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            // Считывание с консоли нажатия
            ConsoleKeyInfo Menu = Console.ReadKey();
            if (Menu.Key == ConsoleKey.Enter) Main();
        }
    }
}
