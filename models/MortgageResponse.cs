namespace MovingCostEstimate.Models
{
    public class MortgageResponse
    {
        public decimal MonthlyPayment { get; set; }
        public decimal TotalPaid { get; set; }

        public decimal TotalInterest { get; set;}
    }
}