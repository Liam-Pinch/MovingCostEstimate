namespace MovingCostEstimate.models.Mortgage
{
    public class MortgageRequest //model for House Purchasing Costs.
    {
        public decimal HousePrice { get; set; }
        public decimal Deposit { get; set; }
        public double AnnualInterestRate { get; set; }
        public int TermYears { get; set; }
        
    }
}