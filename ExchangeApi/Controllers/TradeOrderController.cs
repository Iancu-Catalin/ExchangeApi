using ExchangeApi.Services;
using ExchangeApi.Utils;

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
        public async Task<IActionResult> GetTradeOrders([FromQuery] PaginationParameters paginationParameters)
        {
            var tradeOrders = await _exchangeService.GetTradeOrdersAsync(paginationParameters);

            if (tradeOrders == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no Trade Orders");
            }

            return StatusCode(StatusCodes.Status200OK, tradeOrders);
        }
    }
}
