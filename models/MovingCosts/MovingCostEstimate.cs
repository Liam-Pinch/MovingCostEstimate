
namespace MovingCostEstimate.models.MovingCosts
{
    public class MovingCostRequest
    {
        public MovingCostVan? Van { get; set; }
        public MovingCostKitchen? Kitchen { get; set; }
        public List<MovingCostBedroom> Bedroom { get; set; } = new();
        public MovingCostLivingRoom? LivingRoom { get; set; }
        public MovingCostEssentials? Essentials { get; set; }
        public MovingCostDecorating? Decorating { get; set; }
        
        public MovingCostBathroom? Bathroom { get; set; }
    }
}