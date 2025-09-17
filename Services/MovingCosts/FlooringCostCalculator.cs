namespace MovingCostEstimate.Services.MovingCosts
{
    public static class FlooringCostCalculatorUtility
    {
        public static decimal CalculateFlooringCost(decimal LengthOfRoom, decimal WidthOfRoom, decimal costOfFlooring,
         bool Underlay, decimal UnderlayCost)
        {
            if (!Underlay)
            {
                return LengthOfRoom * WidthOfRoom * costOfFlooring;
            }
            return (LengthOfRoom * WidthOfRoom * costOfFlooring) + (LengthOfRoom * WidthOfRoom * UnderlayCost); 
        }
    }
}