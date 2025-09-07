using MovingCostEstimate.models.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class VanCostCalculator
    {
        public decimal CalculateVan(MovingCostVan Van)
        {
            return (Van.VanHire * Van.VanHireDays) + Van.VanFuel + (Van.ProfessionalMovers * Van.VanHireDays);
            
        }
    }
}