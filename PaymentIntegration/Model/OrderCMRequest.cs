namespace PaymentIntegration.Model
{
    public class OrderCMRequest : IRequestModel
    {
        public string Pk { get; set; }
        public string CardNo { get; set; }
        public int Expiry { get; set; }
        public string Cvv2 { get; set; }
    }
}
