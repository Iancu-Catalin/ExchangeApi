namespace ExchangeApi.Dtos
{
    public class WithdrawalDto
    {
        public decimal Amount { get; set; }
        public string ToAdress { get; set; }
        public bool WasApprovedByUser2fA { get; set; }
    }
}
