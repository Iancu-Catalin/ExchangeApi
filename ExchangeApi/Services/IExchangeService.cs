using ExchangeApi.Dtos;
using ExchangeApi.Models;

namespace ExchangeApi.Services
{
    public interface IExchangeService
    {
        Task<List<OperationType>> GetOperationTypesAsync(); // Will get all the operation types
        //Task<List<Operation>> GetOperationsAsync();
        Task<List<Operation>> GetOperationsAsync(int pageNumber, int pageSize); // Will get all the operations
        Task<IQueryable<WithdrawalDto>> GetWithdrawalsAsync(); // Will get all the withdrawals
        Task<IQueryable<DepositDto>> GetDepositsAsync(); // Will get all the deposits
        Task<List<TradeOrder>> GetTradeOrdersAsync(); // Will get all the Trade Orders
        Task<List<TradeOrderType>> GetTradeOrderTypesAsync(); // Will get all the Trade Order Types
    }
}
