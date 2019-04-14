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
            /// ----- Lesson 7 ----- /// Класс "Горизонтальные/Вертикальные линии" ///
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

            Console.ReadLine();
        }

        
    }
}
