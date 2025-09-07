using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using MovingCostEstimate.models.MovingCosts;
using MovingCostEstimate.Services.MovingCosts;

namespace MovingCostEstimate.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MovingCostController : ControllerBase
    {
        private readonly VanCostCalculator _vanCalculator;
        private readonly KitchenCostCalculator _kitchenCalculator;
        private readonly LivingRoomCostCalculator _livingroomCalculator;
        private readonly BedroomCostCalculator _bedroomCalculator;
        private readonly EssentialsCostCalculator _essentialsCalculator;
        private readonly DecoratingCostCalculator _decoratingCalculator;
        private readonly MovingCostAggregator _movingCostAggregator;

        public MovingCostController(
            VanCostCalculator vanCalculator,
            KitchenCostCalculator kitchenCalculator,
            LivingRoomCostCalculator livingroomCalculator,
            BedroomCostCalculator bedroomCalculator,
            EssentialsCostCalculator essentialsCalculator,
            DecoratingCostCalculator decoratingCalculator,
            MovingCostAggregator movingCostAggregator
        )
        {
            _vanCalculator = vanCalculator;
            _kitchenCalculator = kitchenCalculator;
            _livingroomCalculator = livingroomCalculator;
            _bedroomCalculator = bedroomCalculator;
            _essentialsCalculator = essentialsCalculator;
            _decoratingCalculator = decoratingCalculator;
            _movingCostAggregator = movingCostAggregator;
        }

        [HttpPost("van")]
        public ActionResult<decimal> CalculateVan([FromBody] MovingCostVan van) => Ok(_vanCalculator.CalculateVan(van));
        [HttpPost("kitchen")]
        public ActionResult<decimal> CalculateKitchen([FromBody] MovingCostKitchen kitchen) => Ok(_kitchenCalculator.CalculateKitchen(kitchen));
        [HttpPost("livingroom")]
        public ActionResult<decimal> CalculateLivingRoom([FromBody] MovingCostLivingRoom livingroom) => Ok(_livingroomCalculator.CalculateLivingRoom(livingroom));
        [HttpPost("bedroom")]
        public ActionResult<decimal> CalculateBedroom([FromBody] MovingCostBedroom bedroom) => Ok(_bedroomCalculator.CalculateBedroom(bedroom));
        [HttpPost("essentials")]
        public ActionResult<decimal> CalculateEssentials([FromBody] MovingCostEssentials essentials) => Ok(_essentialsCalculator.CalculateEssentials(essentials));
        [HttpPost("decorating")]
        public ActionResult<decimal> CalculateDecorating([FromBody] MovingCostDecorating decorating) => Ok(_decoratingCalculator.CalculateDecorating(decorating));
        [HttpPost("total")]
        public ActionResult<MovingCostResponse> CalculateTotal([FromBody] MovingCostRequest request) => Ok(_movingCostAggregator.TotalCost(request.Van, request.Kitchen,
        request.LivingRoom, request.Bedroom, request.Essentials, request.Decorating));
    }    
        
}