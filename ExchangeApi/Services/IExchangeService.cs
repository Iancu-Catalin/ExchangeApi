using ExchangeApi.Models;

namespace ExchangeApi.Services
{
    public interface IExchangeService
    {
        Task<List<OperationType>> GetOperationTypes(); // Will get all the operation types
        Task<List<Operation>> GetOperations(); // Will get all the operations
        Task<List<Withdrawal>> GetWithdrawals(); // Will get all the withdrawals
        Task<List<Deposit>> GetDeposits(); // Will get all the deposits
        Task<List<TradeOrder>> GetTradeOrders(); // Will get all the Trade Orders
        Task<List<TradeOrderType>> GetTradeOrderTypes(); // Will get all the Trade Order Types

    }
}
