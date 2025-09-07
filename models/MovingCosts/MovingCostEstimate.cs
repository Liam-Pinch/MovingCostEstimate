
namespace MovingCostEstimate.models.MovingCosts
{
    public class MovingCostRequest
    {
        public MovingCostVan? Van { get; set; }
        public MovingCostKitchen? Kitchen { get; set; }
        public MovingCostBedroom? Bedroom { get; set; }
        public MovingCostLivingRoom? LivingRoom { get; set; }
        public  MovingCostEssentials? Essentials { get; set; }
        public MovingCostDecorating? Decorating { get; set; }
    }
}