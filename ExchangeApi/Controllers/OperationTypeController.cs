using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationTypeController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        public OperationTypeController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOperationTypes()
        {
            var operationTypes = await _exchangeService.GetOperationTypesAsync();

            if (operationTypes == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no operation types.");
            }

            return StatusCode(StatusCodes.Status200OK, operationTypes);
        }
    }
}
