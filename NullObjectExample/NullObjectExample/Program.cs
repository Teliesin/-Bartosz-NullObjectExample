using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IPawn> pawns = new Dictionary<string, IPawn>();

            pawns.Add("A1", new Pawn());
            pawns.Add("A2", new NullObjectPawn());

            IPawn pawn = pawns["A1"];
            pawn.Move();

            IPawn pawn2 = pawns["A2"];
            pawn2.Move();

            Console.ReadKey();
        }
    }
}
