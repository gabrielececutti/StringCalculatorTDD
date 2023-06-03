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
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            return 1;
        }
    }
}
