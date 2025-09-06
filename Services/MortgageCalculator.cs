using Microsoft.AspNetCore.Authentication;
using MovingCostEstimate.models;
using MovingCostEstimate.Models;

namespace MovingCostEstimate.Services
{
    public static class MortgageCalculator 
    { // Calculation is based on the formula M = P x r(1+r)^n / (1 + r)^n - 1.
        public static MortgageResponse Calculate(MortgageRequest request)
        {
            decimal principle = request.HousePrice - request.Deposit;
            double monthlyRate = (request.AnnualInterestRate / 100) / 12;
            int months = request.TermYears * 12;

            decimal monthlyRepayment = (decimal)(
                (double)principle * monthlyRate * Math.Pow(1 + monthlyRate, months) /
                (Math.Pow(1 + monthlyRate, months) - 1)
            );

            decimal totalPaid = monthlyRepayment * months;
            decimal totalInterest = totalPaid - principle;

            return new MortgageResponse
            {
                MonthlyPayment = Math.Round(monthlyRepayment, 2),
                TotalPaid = Math.Round(totalPaid, 2),
                TotalInterest = Math.Round(totalInterest, 2)
            };
        }
    }
}