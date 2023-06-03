using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary
{
    public class StringCalculator : IStringCalculator
    {
        private readonly IStringCalculatorHandler _stringCalculatorHandler; 

        public StringCalculator(IStringCalculatorHandler stringCalculatorHandler)
        {
            _stringCalculatorHandler = stringCalculatorHandler;
        }

        public int Calculate(string input)
        {
            return _stringCalculatorHandler.Handle(input);
        }
    }
}
