using ExchangeApi.Dtos;
using ExchangeApi.Utils;

namespace ExchangeApi.Services
{
    public interface IExchangeService
    {
        Task<IQueryable<WithdrawalDto>> GetWithdrawalsAsync(PaginationParameters paginationParameters); // Will get all the withdrawals
        Task<IQueryable<DepositDto>> GetDepositsAsync(PaginationParameters paginationParameters); // Will get all the deposits
        Task<List<TradeOrderDto>> GetTradeOrdersAsync(PaginationParameters paginationParameters); // Will get all the Trade Orders
    }
}
