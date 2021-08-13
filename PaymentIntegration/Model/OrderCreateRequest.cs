namespace PaymentIntegration.Model
{
    public class OrderCreateRequest : IRequestModel
    {
        public int Currency { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public long Amount { get; set; }
    }
}

