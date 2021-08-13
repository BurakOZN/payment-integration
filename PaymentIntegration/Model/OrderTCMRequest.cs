namespace PaymentIntegration.Model
{
    public class OrderTCMRequest:IRequestModel
    {
        public string Pk { get; set; }
        public string CardNo { get; set; }
        public int Expiry { get; set; }
        public string Cvv2 { get; set; }
        public string ReturnUrlParams { get; set; }
        public string ReturnUrl { get; set; }
    }
}
