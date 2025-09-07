using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class EssentialsCostCalculator
    {
        public decimal CalculateEssentials(MovingCostEssentials Essentials)
        {
            return Essentials.CleaningSupplies + Essentials.CouncilTax + Essentials.Electric +
            Essentials.Gas + Essentials.Groceries + Essentials.InternetInstall + Essentials.Water;

            
        }
    }
}