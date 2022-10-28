using ExchangeApi.Data;
using ExchangeApi.Dtos;

using Microsoft.EntityFrameworkCore;

namespace ExchangeApi.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly AppDbContext _db;

        public ExchangeService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<DepositDto>> GetDepositsAsync()
        {
            try
            {
                var deposit = from d in _db.Deposits
                              select new DepositDto()
                              {
                                  Amount = d.Amount,
                                  FromAdress = d.FromAddress
                              };

                return deposit;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<TradeOrderDto>> GetTradeOrdersAsync()
        {
            try
            {
                var tradeOrder = await _db.TradeOrders
                    .Include(t => t.TradeOrderType)
                    .Select(t => new TradeOrderDto()
                    {
                        Amount = t.Amount,
                        TradeOrderType = t.TradeOrderType.Name
                    })
                    .ToListAsync();

                return tradeOrder;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IQueryable<WithdrawalDto>> GetWithdrawalsAsync()
        {
            try
            {
                var withdrawal = from w in _db.Withdrawals
                                 select new WithdrawalDto()
                                 {
                                     Amount = w.Amount,
                                     ToAdress = w.ToAddress
                                 };

                return withdrawal;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
