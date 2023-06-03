using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculatorTesting.ChainTest
{
    public class EmptyStringHandlerTest
    {
        private IStringCalculatorHandler _sut;
        public EmptyStringHandlerTest()
        {
            _sut = new EmptyStringHandler();
        }

        [Fact]
        public void Should_Handle_Empty_String()
        {
        }
    }

}
