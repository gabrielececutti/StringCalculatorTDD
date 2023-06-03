using StringCalculatorConsoleApp.IOC;
using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting.ChainTest
{
    public class NumbersBiggerThan1000HandlerTest
    {
        private readonly IStringCalculatorHandler _sut;

        public NumbersBiggerThan1000HandlerTest(IStringCalculatorHandler sut)
        {
            _sut = new NumbersBiggerThan1000Handler();
        }

        public void Should_Ignore_Numbers_Bigger_Than_1000()
        {

        }
    }
}
