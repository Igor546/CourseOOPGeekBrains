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
            /// ----- Lesson 3 ----- /// Процедурный подход ///
            Point dotTwo = new Point();
            dotTwo.x = 3;
            dotTwo.y = 4;
            dotTwo.symbols='@';
            dotTwo.Draw();

            Point dotOne = new Point();
            dotOne.x = 6;
            dotOne.y = 4;
            dotOne.symbols = '@';
            dotOne.Draw();

            Console.ReadLine();
        }

        
    }
}
