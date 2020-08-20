namespace PaymentIntegration.Model
{
    public class PreAuthRequest:IRequestModel
    {
        public string CardNo { get; set; }
        public int Expiry { get; set; }
        public string Cvv2 { get; set; }
        public long Amount { get; set; }
        public int Currency { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public bool Ecommerce { get; set; }
        public string Version { get; set; }
        public string SourceType { get; set; }
    }

}
