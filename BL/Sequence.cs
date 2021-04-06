using System.Collections.Generic;

namespace Fibonachi.BL
{
    class Sequence
    {
        private const int FIRST_NUMBER = 0;
        private const int SECOND_NUMBER = 1;

        public Sequence(int minNumber, int maxNumber, out List<int> l)
        {
            CountFromTo(minNumber, maxNumber, out l);
        }

        private void CountToNumber(int number, out int first, out int second)
        {
            first = FIRST_NUMBER + SECOND_NUMBER;
            second = SECOND_NUMBER + first;
            int temp = second;
            while (temp+first < number)
            {
                temp = first + second;
                first = second;
                second = temp;               
            }
        }
        
        private void CountFromTo(int minNumber, int maxNumber, out List<int> numbers)
        {
            numbers = new List<int>();

            CountToNumber(minNumber, out int first, out int second);
            
            if( minNumber <2)
            {
               numbers.Add(1);
            }
            if(minNumber < 3)
            {
                numbers.Add(2);
            }
            
            int temp;
            do
            {               
                temp = first + second;
                first = second;
                second = temp;

                if(temp <= maxNumber && temp >= minNumber)
                numbers.Add(temp);
            }
            while (first+second <= maxNumber);          

        }
    }
}
