using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    public class Counter
    {
        private int _counter;

        public Counter(int counter)
        {
            _counter = counter;
        }
        public Counter()
        {
            _counter = 0;
        }
        public int Counter1
        {
            get => _counter;
            set => _counter = value;
        }
        public void Increment(int amount)
        {
            Counter1 += amount;
        }
        public void Decrement(int amount)
        {
            Counter1-= amount;
        }
        public void ShowCounter()
        {
            Console.WriteLine(_counter);
        }
    }
}
