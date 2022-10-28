using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeOrderController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        public TradeOrderController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTradeOrders()
        {
            var tradeOrders = await _exchangeService.GetTradeOrdersAsync();

            if (tradeOrders == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no Trade Orders");
            }

            return StatusCode(StatusCodes.Status200OK, tradeOrders);
        }
    }
}
