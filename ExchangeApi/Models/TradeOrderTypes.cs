using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class TradeOrderTypes
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
