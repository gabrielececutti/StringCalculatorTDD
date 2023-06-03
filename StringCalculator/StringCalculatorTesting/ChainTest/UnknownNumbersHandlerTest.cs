using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting.ChainTest
{
    public class UnknownNumbersHandlerTest
    {
        private IStringCalculatorHandler _sut;
        public UnknownNumbersHandlerTest()
        {
            _sut = new UnKnownNumbersHandler();
        }

        [Fact]
        public void Should_Handle_Unknown_Numbers()
        {
        }
    }
}
