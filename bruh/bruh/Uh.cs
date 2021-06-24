using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class Uh
    {
        public int x;
        public int y;
        public char sym;

        public Uh()
        {

        }
        public Uh(int _x, int _y, char _sym)

        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Uh(Uh p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direction == Direction.UP)
            {
                y = y - offset;
            }
            if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsBonk(Uh p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
