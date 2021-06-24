using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    class snek:idk
    {
        Direction direction;
        public snek(Uh tail, int lenght, Direction _direction)
        {
            pList = new List<Uh>();
            for (int i = 0; i <= lenght; i++)
            {
                Uh p = new Uh(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Uh tail = pList.First();
            pList.Remove(tail);
            Uh head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Uh GetNextPoint()
        {
            Uh head = pList.Last();
            Uh nextPoint = new Uh(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }

        internal bool IsBonkTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsBonk(pList[i]))
                    return true;
            }
            return false;
        }
        public void HandleKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }

        internal bool Eat (Uh nom)
        {
            Uh head = GetNextPoint();
            if (head.IsBonk(nom))
            {
                nom.sym = head.sym;
                pList.Add(nom);
                return true;
            }
            else
                return false;
        }
    }
}
