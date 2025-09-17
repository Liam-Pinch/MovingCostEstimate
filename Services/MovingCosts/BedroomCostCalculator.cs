using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class BedroomCostCalculator
    {
        public decimal CalculateBedroom(MovingCostBedroom Bedroom)
        {
            decimal paintCost = CostCalculatorUtilityFunctions.CalculatePaintCosts(Bedroom.LengthOfRoom, Bedroom.HeightOfRoom, Bedroom.WidthOfRoom,
            Bedroom.PaintCoverage, Bedroom.PaintCost, Bedroom.NumberOfCoats);

            decimal CostOfFloor = FlooringCostCalculatorUtility.CalculateFlooringCost(Bedroom.LengthOfRoom, Bedroom.WidthOfRoom, Bedroom.FlooringCost, Bedroom.Underlay, Bedroom.UnderlayCost);

            return paintCost + CostOfFloor + Bedroom.Bed + Bedroom.Bedding + Bedroom.BedroomLamps + Bedroom.ChestOfDraws + Bedroom.Mattress +
            Bedroom.Wardrobe;

            
        }
    }
}