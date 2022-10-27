using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("Withdrawals")]
    public class Withdrawal
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool WasApprovedByUser2fA { get; set; }
        public string ToAdress { get; set; }

        public int OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
