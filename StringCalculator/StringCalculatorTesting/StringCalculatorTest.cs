using Microsoft.Extensions.DependencyInjection;
using StringCalculatorConsoleApp.IOC;
using StringCalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTesting
{
    public class StringCalculatorTest
    {
        private IStringCalculator _sut;

        public StringCalculatorTest()
        {
            _sut = StartUp.GetService<IStringCalculator>();
        }
    }
}
