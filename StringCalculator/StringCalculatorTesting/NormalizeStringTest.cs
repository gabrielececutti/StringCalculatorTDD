using StringCalculatorLibrary;
using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting
{
    public class NormalizeStringTest
    {

        [Fact]
        public void Should_Handle_NewLine()
        {
            var expected = new int[] { 1, 2, 3 };
            Assert.Equal("1, 2\n3".ToIntArray(),expected);
        }

        [Fact]
        public void Should_Throw_Exception_With_NewLine_Comma_In_Sequence()
        {
            Assert.Throws<Exception>(() => "2,\n3".ToIntArray());
        }

        public void Should_Handle_Different_Delimiters()
        {

        }

        public void Should_Throw_Excpetion_With_Delimiter_At_End()
        {

        }

        public void Should_Throw_Excpetion_With_Delimiter_In_Sequence()
        {

        }

        public void Should_Throw_Excpetion_With_Incorrect_Use_New_Delimiter()
        {

        }
    }
}
