using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class wals
    {
        List<idk> wList;

        public wals(int mapWidth, int mapHeight)
        {
            wList = new List<idk>();

            lines upLine = new lines(0, mapWidth - 2, 0, '_');
            lines downLine = new lines(0, mapWidth - 2, mapHeight - 1, '_');
            vLines leftLine = new vLines(0, mapHeight - 1, 0, '|');
            vLines rightLine = new vLines(0, mapHeight - 1, mapWidth - 2, '|');

            wList.Add(upLine);
            wList.Add(downLine);
            wList.Add(leftLine);
            wList.Add(rightLine);
        }

        internal bool IsBonk(idk aa)
        {
            foreach (var wal in wList)
            {
                if (wal.IsBonk(aa))
                {
                    return true;
                }

            }
            return false;
        }

        public void Draw()
        {
            foreach (var wal in wList)
            {
                wal.Draw();
            }
        }
    }
}
