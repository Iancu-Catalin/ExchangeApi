using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class Withdrawals
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool WasApprovedByUser2fA { get; set; }
        public string ToAdress { get; set; }

        // Many-to-one relationship with Operations
        public Operations OperationId { get; set; }
    }
}
