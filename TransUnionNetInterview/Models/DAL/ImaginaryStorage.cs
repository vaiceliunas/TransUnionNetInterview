using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransUnionNetInterview
{
    public static class ImaginaryStorage
    {
        public static List<AtmMachineCurrency> GetCurrenciesFromStorage()
        {
            return new List<AtmMachineCurrency>()
            {
                new()
                {
                    Amount = 500,
                    LeftCount = 500
                },
                new()
                {
                    Amount = 200,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 100,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 50,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 20,
                    LeftCount = 20
                },
                new()
                {
                    Amount = 10,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 5,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 2,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 1,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.5M,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.5M,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.2M,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.1M,
                    LeftCount = 100
                },
                new()
                {
                    Amount = 0.05M,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.02M,
                    LeftCount = 2
                },
                new()
                {
                    Amount = 0.01M,
                    LeftCount = 100
                }
            };
        }
    }
}
