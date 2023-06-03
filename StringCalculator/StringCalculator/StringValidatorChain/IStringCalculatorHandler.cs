using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary.StringValidatorChain
{
    public interface IStringCalculatorHandler
    {
        int Handle(string input);
        void SetSuccessor(IStringCalculatorHandler stringCalculator);
    }
}
