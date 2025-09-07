using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class VanCostCalculator
    {
        public decimal CalculateVan(MovingCostVan Van)
        {
            return (Van.VanFuel * Van.VanHireDays) + (Van.ProfessionalMovers * Van.VanHireDays) + Van.VanFuel;
            
        }
    }
}