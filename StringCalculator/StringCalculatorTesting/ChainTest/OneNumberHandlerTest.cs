
using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting.ChainTest
{
    public class OneNumberHandlerTest
    {
        private IStringCalculatorHandler _sut;
        public OneNumberHandlerTest()
        {
            _sut = new OneNumberHandler();
        }

        [Fact]
        public void Should_Handle_One_Number()
        {
        }
    }
}
