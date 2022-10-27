using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("Operations")]
    public class Operation
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public int OperationTypeId { get; set; }
        public OperationType OperationType { get; set; }

        public List<Deposit> Deposits { get; set; }

        public List<Withdrawal> Withdrawals { get; set; }

        public List<TradeOrder> TradeOrders { get; set; }
    }
}
