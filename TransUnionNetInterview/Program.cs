using System;
using TransUnionNetInterview.ProblemSolver.Interfaces;

namespace TransUnionNetInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetSum = 8076.58M;


            var atmMachine = AtmMachine.CreateInstance(ImaginaryStorage.GetCurrenciesFromStorage(), new BruteForceCalculator());
            var result = atmMachine.ProvidePossibleExchanges(targetSum);
            if (result.Count == 0)
                throw new Exception("Atm machine was unable to get results");


            Console.WriteLine("Target sum is : " + Math.Round(targetSum, 2));
            Console.WriteLine("This is what ATM machine gave back");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Calculations are done");
            Console.ReadLine();
        }
    }
}
