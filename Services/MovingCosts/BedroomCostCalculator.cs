using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class BedroomCostCalculator
    {
        public decimal CalculateBedroom(MovingCostBedroom Bedroom)
        {
            return Bedroom.Bed + Bedroom.Bedding + Bedroom.BedroomLamps + Bedroom.ChestOfDraws + Bedroom.Mattress +
            Bedroom.Wardrobe;

            
        }
    }
}