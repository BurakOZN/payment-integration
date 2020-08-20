namespace PaymentIntegration.Model
{
    public class RefundRequest : IRequestModel
    {
        public string ProcessId { get; set; }
        public long Amount { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public bool Ecommerce { get; set; }
    }


}
