using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class FoodBruh
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodBruh(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Uh Fod()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Uh(x, y, sym);
        }
        
    }
}
