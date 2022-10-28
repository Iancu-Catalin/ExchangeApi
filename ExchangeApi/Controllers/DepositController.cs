using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        public DepositController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetDeposits()
        {
            var deposits = await _exchangeService.GetDepositsAsync();

            if (deposits == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no deposits.");
            }

            return StatusCode(StatusCodes.Status200OK, deposits);
        }
    }
}
