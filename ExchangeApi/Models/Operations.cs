using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class Operations
    {
        [Key]
        public int Id { get; set; }
        public decimal? Amount { get; set; }
    }
}
