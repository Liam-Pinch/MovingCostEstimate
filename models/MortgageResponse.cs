namespace MovingCostEstimate.Models
{
    public class MortgageResponse // model for response after calculation.
    {
        public decimal MonthlyPayment { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal TotalInterest { get; set;}
    }
}