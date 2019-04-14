using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ----- Lesson 1 ----- /// Введение ///
            //Console.WriteLine("Hello world!");
            //Console.ReadLine();

            /// ----- Lesson 2 ----- /// Процедурный подход ///
            Draw(1, 1, '#');
            Draw(1, 3, '#');
            Draw(3, 1, '#');
            Draw(3, 3, '#');
            Console.ReadLine();
        }

        /* Процедура отрисовки символа */
        static void Draw(int x, int y, char symbols)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbols);
        }
    }
}
