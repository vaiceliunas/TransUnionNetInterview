using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransUnionNetInterview.ProblemSolver.Interfaces
{
    public class BruteForceCalculator : ICalculator
    {
        private static bool _resultFound = false;
        private static List<decimal> _possibleSolution = new();
        public List<decimal> CalculatePossibleExchange(decimal moneyAmount, List<AtmMachineCurrency> atmHoldingAmount)
        {
            var banknotes = new List<decimal>();
            foreach (var atmMachineCurrency in atmHoldingAmount)
            {
                for (var i = 0; i < atmMachineCurrency.LeftCount; i++)
                {
                    banknotes.Add(atmMachineCurrency.Amount);
                }
            }

            CalculatePossibleExchangeRecursive(banknotes, moneyAmount, new List<decimal>());

            return _possibleSolution;
        }

        private static void CalculatePossibleExchangeRecursive(List<decimal> banknotes, decimal target,
            List<decimal> possibleResult)
        {
            if (_resultFound)
                return;

            var s = possibleResult.Sum();

            if (s == target)
            {
                _possibleSolution = possibleResult;
                _resultFound = true;
                return;
            }

            if (s > target)
                return;

            for (var i = 0; i < banknotes.Count; i++)
            {
                var remaining = new List<decimal>();
                var n = banknotes[i];
                for(var j = i + 1; j < banknotes.Count; j ++)
                    remaining.Add(banknotes[j]);

                var partialWithAddedN = new List<decimal>(possibleResult) {n};
                CalculatePossibleExchangeRecursive(remaining, target, partialWithAddedN);
            }
        }
    }
}
