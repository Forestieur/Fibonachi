using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonachi.BL;

namespace Fibonachi
{
    class Program
    {
        static void Main()
        {
            Sequence s = new Sequence();
            s.CountFromTo(10,2000, out _);
            Console.ReadLine();
        }
    }
}
