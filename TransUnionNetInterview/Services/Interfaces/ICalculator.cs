using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransUnionNetInterview.ProblemSolver.Interfaces
{
    public interface ICalculator
    {
        List<decimal> CalculatePossibleExchange(decimal moneyAmount, List<AtmMachineCurrency> atmHoldingAmount);
    }
}
