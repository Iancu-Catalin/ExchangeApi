using ExchangeApi.Models;

namespace ExchangeApi.Services
{
    public interface IExchangeService
    {
        Task<List<OperationType>> GetOperationTypesAsync(); // Will get all the operation types
        Task<List<Operation>> GetOperationsAsync(); // Will get all the operations
        Task<List<Withdrawal>> GetWithdrawalsAsync(); // Will get all the withdrawals
        Task<List<Deposit>> GetDepositsAsync(); // Will get all the deposits
        Task<List<TradeOrder>> GetTradeOrdersAsync(); // Will get all the Trade Orders
        Task<List<TradeOrderType>> GetTradeOrderTypesAsync(); // Will get all the Trade Order Types
    }
}
