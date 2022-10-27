using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("Deposits")]
    public class Deposit
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string FromAddress { get; set; }

        public int OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
