using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class Withdrawals
    {
        [Key]
        public Guid Id { get; set; }
        public decimal? Amount { get; set; }
        public bool? WasApprovedByUser2fA { get; set; }
        public string? ToAdress { get; set; }
    }
}
