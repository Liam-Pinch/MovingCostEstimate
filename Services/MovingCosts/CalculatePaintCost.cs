namespace MovingCostEstimate.Services.MovingCosts
{
    public static class CostCalculatorUtilityFunctions
    {
        public static decimal CalculatePaintCosts(decimal length, decimal height, decimal width,
             decimal paintCoverage, decimal paintCost, decimal numberOfCoats)
        {
            var wallArea = ((2 * length * height) + (2 * width * height)) * numberOfCoats;
            var paintUnits = (int)Math.Ceiling(wallArea / paintCoverage);
            return paintUnits * paintCost;
        }
    }
}