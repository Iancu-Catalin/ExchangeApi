using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class Operations
    {
        [Key]
        public Guid Id { get; set; }
        public decimal? Amount { get; set; }
    }
}
