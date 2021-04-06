using System;
using System.Collections.Generic;

namespace Fibonachi.View
{
    class View
    {
        public static void DisplayNumbers(List<int> numbers)
        {
            foreach(int n in numbers)
            {
                Console.Write($"{n} ");
            }
            Console.ReadLine();
        }
    }
}
