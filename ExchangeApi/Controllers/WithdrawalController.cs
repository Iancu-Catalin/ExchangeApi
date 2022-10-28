using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WithdrawalController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        public WithdrawalController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        [HttpGet]

        public async Task<IActionResult> GetWithdrawals()
        {
            var withdrawals = await _exchangeService.GetWithdrawalsAsync();

            if (withdrawals == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no Withdrawals.");
            }

            return StatusCode(StatusCodes.Status200OK, withdrawals);
        }
    }
}
