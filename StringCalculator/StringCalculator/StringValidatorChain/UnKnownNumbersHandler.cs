using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary.StringValidatorChain
{
    public class UnKnownNumbersHandler : StringCalculatorHandler
    {
        public override int Handle(string input)
        {
            if (input.Length > 1) 
            {
                return input.Split(",").Select(n => int.Parse(n.ToString())).Sum();
            }
            return 0;
        }
    }
}
