using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransUnionNetInterview.ProblemSolver.Interfaces;

namespace TransUnionNetInterview
{
    public class AtmMachine
    {
        private List<AtmMachineCurrency> CurrentAtmAmount { get; set;}
        private ICalculator ProblemSolver { get; set; }

        private AtmMachine(List<AtmMachineCurrency> moneyAmount, ICalculator problemSolver)
        {
            CurrentAtmAmount = moneyAmount;
            ProblemSolver = problemSolver;
        }

        public static AtmMachine CreateInstance(List<AtmMachineCurrency> moneyAmount, ICalculator problemSolver)
        {
            return new AtmMachine(moneyAmount, problemSolver);
        }

        public List<decimal> ProvidePossibleExchanges(decimal moneyAmount)
        {
            return ProblemSolver.CalculatePossibleExchange(moneyAmount, CurrentAtmAmount);
        }
    }
}
