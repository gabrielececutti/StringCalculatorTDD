using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary.StringValidatorChain
{
    public class NegativeNumbersHandler : AbstractCalculatorHandler
    {
        public override int Handle(string input)
        {
            var numbers = input.ToIntArray();
            if (numbers.Any( n => n < 0)) // negative numbers are invalid
            {
                var negativeNumbers = numbers.Where(n => n < 0);
                var message = $"Negative number(s) not allowed: {string.Join(", ", negativeNumbers)}";
                throw new Exception(message);
            }
            return 0;
        }
    }
}
