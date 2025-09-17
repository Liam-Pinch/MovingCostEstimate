using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts {
    public class BathroomCostCalculator
    {
        public decimal CalculateBathroom(MovingCostBathroom bathroom)
        {

            decimal paintCost = CostCalculatorUtilityFunctions.CalculatePaintCosts(bathroom.LengthOfRoom, bathroom.HeightOfRoom, bathroom.WidthOfRoom,
            bathroom.PaintCoverage, bathroom.PaintCost, bathroom.NumberOfCoats);

            decimal CostOfFloor = FlooringCostCalculatorUtility.CalculateFlooringCost(bathroom.LengthOfRoom, bathroom.WidthOfRoom, bathroom.FlooringCost, bathroom.Underlay, bathroom.UnderlayCost);

            return paintCost + CostOfFloor + bathroom.Towels + bathroom.FloorMats
            + bathroom.ShowerCurtain;

        }
    }
}