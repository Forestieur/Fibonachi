using Fibonachi.BL;
using System.Collections.Generic;

namespace Fibonachi.View
{
    class ConsoleOutput
    {
        private Sequence _sequence;

        public ConsoleOutput(int min, int max)
        {
            ShowNumbers(min, max);           
        }

        private void ShowNumbers(int min, int max)
        {           
            _sequence = new Sequence(min, max, out List<int> l);
            View.DisplayNumbers(l);
        }
    }
}
