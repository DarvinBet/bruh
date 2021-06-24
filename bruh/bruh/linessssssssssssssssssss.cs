using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class lines : idk
    {
        public lines(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Uh>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Uh p = new Uh(x, y, sym);
                pList.Add(p);   
            }
        }

    }
}
