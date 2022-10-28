using ExchangeApi.Services;

using Microsoft.AspNetCore.Mvc;

namespace ExchangeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IExchangeService _exchangeService;

        public OperationController(IExchangeService exchangeService)
        {
            _exchangeService = exchangeService;
        }

        /*
        [HttpGet]
        public async Task<IActionResult> GetOperations()
        {
            var operations = await _exchangeService.GetOperationsAsync();

            if (operations == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no operations.");
            }

            return StatusCode(StatusCodes.Status200OK, operations);
        }
        */

        [HttpGet("{pageNumber}/{pageSize}")]
        public async Task<IActionResult> GetOperations(int pageNumber, int pageSize)
        {
            var operations = await _exchangeService.GetOperationsAsync(pageNumber, pageSize);

            if (operations == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "There are no operations.");
            }

            return StatusCode(StatusCodes.Status200OK, operations);
        }
    }
}
