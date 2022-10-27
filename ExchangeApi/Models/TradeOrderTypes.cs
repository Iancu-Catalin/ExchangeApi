using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class TradeOrderTypes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
