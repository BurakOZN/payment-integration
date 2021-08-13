namespace PaymentIntegration.Model
{
    public class OrderCreateResponse
    {
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string OrderId { get; set; }
        public string ProcessId { get; set; }
        public string Link { get; set; }
    }
}

