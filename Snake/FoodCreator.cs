using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char symbols;
        public int countNewEat = -1;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char symbols)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.symbols = symbols;

        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            countNewEat = countNewEat + 1;
            return new Point(x, y, symbols);
        }

    }
}
