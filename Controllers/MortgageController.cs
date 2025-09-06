using Microsoft.AspNetCore.Mvc;
using MovingCostEstimate.models;
using MovingCostEstimate.Models;
using MovingCostEstimate.Services;

namespace MovingCostEstimate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MortgageController : ControllerBase
    {
        [HttpPost("calculate")]
        public ActionResult<MortgageResponse> CalculateMortgage([FromBody] MortgageRequest request)
        {
            if (request.TermYears <= 0 || request.HousePrice <= 0 ||
            request.AnnualInterestRate < 0 || request.Deposit <= 0)
                return BadRequest("Invalid Input");

            var result = MortgageCalculator.Calculate(request);
            return Ok(result);
        }
    }
}