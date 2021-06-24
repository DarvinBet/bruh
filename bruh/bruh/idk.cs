using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class idk
    {
        protected List<Uh> pList;

        public virtual void Draw()
        {
            foreach (Uh p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsBonk(idk aa)
        {
            foreach(var p in pList)
            {
                if (aa.IsBonk(p))
                    return true;
            }
            return false;
        }

        private bool IsBonk( Uh poin)
        {
            foreach(var p in pList)
            {
                if (p.IsBonk(poin))
                    return true;
            }
            return false;
        }
    }
}
