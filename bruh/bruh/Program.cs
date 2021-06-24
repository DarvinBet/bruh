using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bruh
{
    class Program
    {
        static void Main(string[] args)
        {

            wals wals = new wals(80, 25);
            wals.Draw();

            

            Uh p = new Uh(40, 12, '#');
            p.Draw();
            snek snak = new snek(p, 4, Direction.RIGHT);
            snak.Draw();

            FoodBruh duh = new FoodBruh(80, 25, 'o');
            Uh nom = duh.Fod();
            nom.Draw();
            
            while(true)
            {
                if(wals.IsBonk(snak) || snak.IsBonkTail())
                {
                    break;
                }
                if(snak.Eat(nom))
                {
                    nom = duh.Fod();
                    nom.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snak.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snak.Move();
            }
        }
        
    }
}
