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

        [Theory]
        [InlineData("3,2,2,1")]
        [InlineData("1, 2\n3,2")]
        public void Should_Handle_Unknown_Numbers(string input)
        {
            var expected = 8;
            var acutal = _sut.Handle(input);
            Assert.Equal(expected, acutal);
        }
    }
}
