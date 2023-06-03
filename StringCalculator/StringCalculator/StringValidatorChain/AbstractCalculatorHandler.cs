using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary.StringValidatorChain
{
    public abstract class AbstractCalculatorHandler : IStringCalculatorHandler
    {
        protected IStringCalculatorHandler _successor;

        public abstract int Handle(string input);

        public void SetSuccessor(IStringCalculatorHandler stringCalculator)
        {
            _successor = stringCalculator;
        }
    }
}
