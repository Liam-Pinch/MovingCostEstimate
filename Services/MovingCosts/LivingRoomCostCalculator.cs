using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class LivingRoomCostCalculator
    {
         public decimal CalculateLivingRoom(MovingCostLivingRoom LivingRoom)
        {

            decimal paintCost = CostCalculatorUtilityFunctions.CalculatePaintCosts(LivingRoom.LengthOfRoom, LivingRoom.HeightOfRoom, LivingRoom.WidthOfRoom,
            LivingRoom.PaintCoverage, LivingRoom.PaintCost, LivingRoom.NumberOfCoats);

            decimal CostOfFloor = FlooringCostCalculatorUtility.CalculateFlooringCost(LivingRoom.LengthOfRoom, LivingRoom.WidthOfRoom, LivingRoom.FlooringCost, LivingRoom.Underlay, LivingRoom.UnderlayCost);

            return paintCost + CostOfFloor + LivingRoom.LivingRoomLamps + LivingRoom.Sofa + LivingRoom.Storage + LivingRoom.TablesAndChairs
            + LivingRoom.Tv + LivingRoom.TvStand;

            
        }
    }
}