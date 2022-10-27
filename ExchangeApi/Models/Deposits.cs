using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class Deposits
    {
        [Key]
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public string? FromAdress { get; set; }
    }
}
