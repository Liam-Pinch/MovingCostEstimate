using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class KitchenCostCalculator
    {
        public decimal CalculateKitchen(MovingCostKitchen Kitchen)
        {

            decimal paintCost = CostCalculatorUtilityFunctions.CalculatePaintCosts(Kitchen.LengthOfRoom, Kitchen.HeightOfRoom, Kitchen.WidthOfRoom,
            Kitchen.PaintCoverage, Kitchen.PaintCost, Kitchen.NumberOfCoats);

            decimal CostOfFloor = FlooringCostCalculatorUtility.CalculateFlooringCost(Kitchen.LengthOfRoom, Kitchen.WidthOfRoom, Kitchen.FlooringCost, Kitchen.Underlay, Kitchen.UnderlayCost);

            return paintCost + CostOfFloor + Kitchen.Cooker + Kitchen.Dishwasher + Kitchen.Freezer + Kitchen.Fridge +
            Kitchen.Kettle + Kitchen.Microwave + Kitchen.Toaster + Kitchen.TumbleDryer + Kitchen.WashingMachine
            + Kitchen.Cutlery + Kitchen.Knives + Kitchen.MixingBowl + Kitchen.Tupperware + Kitchen.Utensils;
            
        }
    }
}