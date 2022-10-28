using ExchangeApi.Dtos;

namespace ExchangeApi.Services
{
    public interface IExchangeService
    {
        Task<IQueryable<WithdrawalDto>> GetWithdrawalsAsync(); // Will get all the withdrawals
        Task<IQueryable<DepositDto>> GetDepositsAsync(); // Will get all the deposits
        Task<List<TradeOrderDto>> GetTradeOrdersAsync(); // Will get all the Trade Orders
    }
}
