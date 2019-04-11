using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectExample
{
    public class NullObjectPawn : IPawn
    {
        public void Move()
        {
            Console.WriteLine("Jestem pustym polem!");
            //throw new ApplicationException("Coś nie poszło nie tak!");
        }
    }
}