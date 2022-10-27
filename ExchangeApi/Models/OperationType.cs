using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeApi.Models
{
    [Table("OperationTypes")]
    public class OperationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Operation> Operations { get; set; }
    }
}
