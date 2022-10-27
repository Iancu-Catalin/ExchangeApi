using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class TradeOrders
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }

    }
}
