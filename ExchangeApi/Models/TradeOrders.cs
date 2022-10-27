using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class TradeOrders
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }

        // Many-to-one relationship with TradeOrderTypes
        public TradeOrderTypes TradeOrderTypeId { get; set; }

        // Many-to-one relationship with Operations
        public Operations OperationId { get; set; }

    }
}
