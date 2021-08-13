namespace PaymentIntegration.Model
{
    public class OrderCHResponse
    {
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public bool Is3D { get; set; }
        public bool IsDone { get; set; }
        public string MerchantName { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
    }
}

