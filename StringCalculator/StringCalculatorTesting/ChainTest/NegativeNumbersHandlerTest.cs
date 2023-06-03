using StringCalculatorConsoleApp.IOC;
using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting.ChainTest
{
    public class NegativeNumbersHandlerTest
    {
        private readonly IStringCalculatorHandler _sut;

        public NegativeNumbersHandlerTest()
        {
            _sut = new NegativeNumbersHandler();
        }

        public void Should_Throw_Exception_With_Negative_Numbers()
        {

        }
    }
}
