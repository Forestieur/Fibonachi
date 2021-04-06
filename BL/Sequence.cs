using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi.BL
{
    class Sequence
    {
        private const int FIRST_NUMBER = 0;
        private const int SECOND_NUMBER = 1;
       // private List<int> numbers;

        public void CountToNumber(int number, out int first, out int second)
        {
             first = FIRST_NUMBER + SECOND_NUMBER;
             second = SECOND_NUMBER + first;         
            while (second+first < number)
            {

                first = second + first;
                second = first + second;
            }

        }
        
        public void CountFromTo(int minNumber, int maxNumber, out List<int> numbers)
        {
            numbers = new List<int>();
            CountToNumber(minNumber, out int first, out int second);
           
            if(second > minNumber)
            {
                numbers.Add(second);
            }
            do
            {
                first = second + first;
                second = first + second;
                numbers.Add(first);
                numbers.Add(second);

            }
            while (first+second < maxNumber);

            foreach( int n in numbers)
            {
                Console.Write($"{n},");
            }

        }
    }
}
