using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class DecoratingCostCalculator
    {
            public decimal CalculateDecorating(MovingCostDecorating Decorating)
        {
            return Decorating.BoxesAndEquiptment + Decorating.FlooringEquipment +
            Decorating.LightFittings + Decorating.PaintEquipment + Decorating.WallpaperingEquipment;

            
        }
    }
}