using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("TradeOrderTypes")]
    public class TradeOrderType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with TradeOrders
        public List<TradeOrder> TradeOrders { get; set; }

    }
}
