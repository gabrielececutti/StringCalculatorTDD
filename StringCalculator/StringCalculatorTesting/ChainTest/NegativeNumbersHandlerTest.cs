﻿using StringCalculatorConsoleApp.IOC;
using StringCalculatorLibrary;
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

        [Fact]
        public void Should_Throw_Exception_With_Negative_Numbers()
        {
            var exception = Assert.Throws<Exception>(() => _sut.Handle("2,-4,-9"));
            Assert.Equal("Negative number(s) not allowed: -4, -9", exception.Message);
        }
    }
}
