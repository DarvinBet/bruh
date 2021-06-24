using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class vLines : idk
    {
        public vLines(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Uh>();
            for (int y= yUp; y<= yDown; y++)
            {
                Uh p = new Uh(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
