using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOrderTypeController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        TradeOrderTypeController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTradeOrderTypes()
        {
            var tradeOrderTypes = await _exchangeService.GetTradeOrderTypesAsync();

            if (tradeOrderTypes == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no Trade Order Types.");
            }

            return StatusCode(StatusCodes.Status200OK, tradeOrderTypes);
        }
    }
}
