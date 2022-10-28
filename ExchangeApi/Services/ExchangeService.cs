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

        public async Task<List<TradeOrder>> GetTradeOrdersAsync()
        {
            try
            {
                return await _db.TradeOrders.ToListAsync();
                //return await _db.TradeOrders.Include(elem => elem.TradeOrderTypeId).ToListAsync();
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

        public async Task<List<Withdrawal>> GetWithdrawalsAsync()
        {
            try
            {
                return await _db.Withdrawals.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
