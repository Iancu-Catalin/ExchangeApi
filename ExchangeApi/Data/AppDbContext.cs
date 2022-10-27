using ExchangeApi.Models;

using Microsoft.EntityFrameworkCore;

namespace ExchangeApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Withdrawal> Withdrawals { get; set; }
        public DbSet<TradeOrder> TradeOrders { get; set; }
        public DbSet<TradeOrderType> TradeOrderTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Define relationship between books and authors
            builder.Entity<OperationType>()
                .HasMany(x => x.Operations)
                .WithOne(x => x.OperationType);

            builder.Entity<Operation>()
                .HasMany(x => x.Deposits)
                .WithOne(x => x.Operation);

            builder.Entity<Operation>()
                .HasMany(x => x.Withdrawals)
                .WithOne(x => x.Operation);

            builder.Entity<Operation>()
                .HasMany(x => x.TradeOrders)
                .WithOne(x => x.Operation);

            builder.Entity<TradeOrderType>()
                .HasMany(x => x.TradeOrders)
                .WithOne(x => x.TradeOrderType);
        }
    }
}
