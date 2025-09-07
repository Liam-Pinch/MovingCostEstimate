using MovingCostEstimate.models.MovingCosts;
using MovingCostEstimate.Services.MovingCosts;

namespace MovingCostEstimate.Services.MovingCosts
{
    public class MovingCostAggregator
    {
        private readonly VanCostCalculator _vanCalculator;
        private readonly KitchenCostCalculator _kitchenCalculator;
        private readonly LivingRoomCostCalculator _livingroomCalculator;
        private readonly BedroomCostCalculator _bedroomCalculator;
        private readonly EssentialsCostCalculator _essentialsCalculator;
        private readonly DecoratingCostCalculator _decoratingCalculator;

        public MovingCostAggregator(
            VanCostCalculator vanCostCalculator,
            KitchenCostCalculator kitchenCostCalculator,
            LivingRoomCostCalculator livingRoomCostCalculator,
            BedroomCostCalculator bedroomCostCalculator,
            EssentialsCostCalculator essentialsCostCalculator,
            DecoratingCostCalculator decoratingCostCalculator
        )
        {
            _vanCalculator = vanCostCalculator;
            _kitchenCalculator = kitchenCostCalculator;
            _livingroomCalculator = livingRoomCostCalculator;
            _bedroomCalculator = bedroomCostCalculator;
            _essentialsCalculator = essentialsCostCalculator;
            _decoratingCalculator = decoratingCostCalculator;

        }

        public MovingCostResponse TotalCost(MovingCostVan van, MovingCostKitchen kitchen, MovingCostLivingRoom livingroom,
        MovingCostBedroom bedroom, MovingCostEssentials essentials, MovingCostDecorating decorating)
        {
            var response = new MovingCostResponse
            {
                Van = _vanCalculator.CalculateVan(van),
                Kitchen = _kitchenCalculator.CalculateKitchen(kitchen),
                Livingroom = _livingroomCalculator.CalculateLivingRoom(livingroom),
                Bedroom = _bedroomCalculator.CalculateBedroom(bedroom),
                Essentials = _essentialsCalculator.CalculateEssentials(essentials),
                Decorating = _decoratingCalculator.CalculateDecorating(decorating)
            };

            response.Total = response.Van + response.Kitchen + response.Livingroom + response.Bedroom +
            response.Essentials + response.Decorating;

            return response;
        }
    }
}
