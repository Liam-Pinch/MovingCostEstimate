using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class DecoratingCostCalculator
    {
            public decimal CalculateDecorating(MovingCostDecorating Decorating)
        {
            return Decorating.BoxesAndEquiptment + Decorating.Curtains + Decorating.FlooringAndEquipment +
            Decorating.LightFittings + Decorating.PaintAndEquipment + Decorating.WallpaperingAndEquipment;

            
        }
    }
}