using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StringCalculatorLibrary;
using StringCalculatorLibrary.StringValidatorChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorConsoleApp.IOC
{
    public static class StartUp
    {
        public static T GetService<T>()
            => CreateHostBuilder().Services.GetService<T>();

        private static IHost CreateHostBuilder() =>
            Host
                .CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                        .AddSingleton<IStringCalculator, StringCalculator>()
                        .AddSingleton<IStringCalculatorHandler>(_ =>
                        {
                            var emptyHandler = new EmptyStringHandler();
                            var oneNumberHandler = new OneNumberHandler();
                            var unknownNumbersHanler = new UnKnownNumbersHandler();

                            emptyHandler.SetSuccessor(oneNumberHandler);
                            oneNumberHandler.SetSuccessor(unknownNumbersHanler);

                            return emptyHandler;
                        })).Build();
    }
}
