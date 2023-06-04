using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary.StringValidatorChain
{
    public class EmptyStringHandler : StringCalculatorHandler
    {
        public override int Handle(string input)
        {
            if (input.ToIntArray().Length == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
