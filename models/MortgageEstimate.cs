namespace MovingCostEstimate.models
{
    public class MortgageRequest
    {
        public decimal HousePrice { get; set; }
        public decimal Deposit { get; set; }

        public double AnnualInterestRate { get; set; }

        public int TermYears { get; set; }
        
    }
}