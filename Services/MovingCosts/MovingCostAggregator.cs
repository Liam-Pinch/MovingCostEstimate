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
                VanTotal = _vanCalculator.CalculateVan(van),
                KitchenTotal = _kitchenCalculator.CalculateKitchen(kitchen),
                LivingroomTotal = _livingroomCalculator.CalculateLivingRoom(livingroom),
                BedroomTotal = _bedroomCalculator.CalculateBedroom(bedroom),
                EssentialsTotal = _essentialsCalculator.CalculateEssentials(essentials),
                DecoratingTotal = _decoratingCalculator.CalculateDecorating(decorating)
            };

            response.TotalCost = response.VanTotal + response.KitchenTotal + response.LivingroomTotal + response.BedroomTotal +
            response.EssentialsTotal + response.DecoratingTotal;

            return response;
        }
    }
}
