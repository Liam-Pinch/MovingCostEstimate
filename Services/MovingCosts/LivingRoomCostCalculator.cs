using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class LivingRoomCostCalculator
    {
         public decimal CalculateLivingRoom(MovingCostLivingRoom LivingRoom)
        {
            return LivingRoom.LivingRoomLamps + LivingRoom.Sofa + LivingRoom.Storage + LivingRoom.TablesAndChairs
            + LivingRoom.Tv + LivingRoom.TvStand;

            
        }
    }
}