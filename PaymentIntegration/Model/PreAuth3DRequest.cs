namespace PaymentIntegration.Model
{
    public class PreAuth3DRequest:IRequestModel
    {
        public string Md { get; set; }
        public string CardNo { get; set; }
        public int Expiry { get; set; }
        public string Cvv2 { get; set; }
        public long Amount { get; set; }
        public int Currency { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public bool Ecommerce { get; set; }
    }

}
