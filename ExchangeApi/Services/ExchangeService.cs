using ExchangeApi.Data;
using ExchangeApi.Dtos;
using ExchangeApi.Models;

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

        /*
        public async Task<List<Operation>> GetOperationsAsync()
        {
            try
            {
                return await _db.Operations.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
        */

        public async Task<List<Operation>> GetOperationsAsync(int pageNumber, int pageSize)
        {
            try
            {
                return await _db.Operations
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<OperationType>> GetOperationTypesAsync()
        {
            try
            {
                return await _db.OperationTypes.ToListAsync();
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

        public async Task<List<TradeOrderType>> GetTradeOrderTypesAsync()
        {
            try
            {
                return await _db.TradeOrderTypes.ToListAsync();
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
