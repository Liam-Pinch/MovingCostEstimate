using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class KitchenCostCalculator
    {
        public decimal CalculateKitchen(MovingCostKitchen Kitchen)
        {
            return Kitchen.Cooker + Kitchen.Dishwasher + Kitchen.Freezer + Kitchen.Fridge +
            Kitchen.Kettle + Kitchen.Microwave + Kitchen.Toaster + Kitchen.TumbleDryer + Kitchen.WashingMachine;

            
        }
    }
}