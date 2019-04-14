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
            /// ----- Lesson 6 ----- /// Осваиваем класс "Список" ///
            
            // List Функция Add (добавить)
            List<int> numList = new List<int>();
            numList.Add(4);
            numList.Add(3);
            numList.Add(2);
            numList.Add(1);
            numList.Add(0);

            // List Функция Add (добавить)
            Point p1 = new Point(3, 4, '$');
            Point p2 = new Point(5, 5, '$');
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            // List Функция Remove (удалить по значению НЕ ИНДЕКСУ)
            numList.Remove(3);

            // Цикл foreach (пробежаться по всем элементам)
            // На каждом шаге записывать в i данный с numList (пока они не закончаться)
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        
    }
}
