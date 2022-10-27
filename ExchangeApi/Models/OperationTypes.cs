using System.ComponentModel.DataAnnotations;

namespace ExchangeApi.Models
{
    public class OperationTypes
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
