using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("TradeOrders")]
    public class TradeOrder
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public int OperationId { get; set; }
        public Operation Operation { get; set; }

        public int TradeOrderTypeId { get; set; }
        public TradeOrderType TradeOrderType { get; set; }
    }
}
