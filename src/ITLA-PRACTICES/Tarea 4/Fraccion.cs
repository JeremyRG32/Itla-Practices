using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    public class Fraccion
    {
        private decimal _numerator;
        private decimal _denominator;

        public Fraccion(decimal numerator, decimal denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public decimal Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }
        public decimal Denominator
        { 
            get => _denominator;
            set => _denominator = value;
        }

        public decimal Add(decimal numerator , decimal denominator)
        {
            var result1 = Numerator / Denominator;
            var result2 = numerator / denominator;
            return result1 + result2;
        }
         public decimal Substract(decimal numerator , decimal denominator)
        {
            var result1 = Numerator / Denominator;
            var result2 = numerator / denominator;
            return result1 - result2;
        }
        public decimal multiply(decimal numerator, decimal denominator)
        {
            var result1 = Numerator / Denominator;
            var result2 = numerator / denominator;
            return result1 * result2;
        }
        public decimal divide(decimal numerator, decimal denominator)
        {
            var result1 = Numerator / Denominator;
            var result2 = numerator / denominator;
            return result1 / result2;
        }
    }
}
