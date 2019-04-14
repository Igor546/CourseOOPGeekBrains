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
            /// ----- Lesson 4 ----- /// Конструкторы, инкапсуляция ///
            Point dotTwo = new Point(3,3,'%');
            dotTwo.Draw(); // Метод отрисовки точки

            Point dotOne = new Point(6,3,'%');
            dotOne.Draw(); // Метод отрисовки точки

            Console.ReadLine();
        }

        
    }
}
