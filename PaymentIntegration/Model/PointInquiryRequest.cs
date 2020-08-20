namespace PaymentIntegration.Model
{
    public class PointInquiryRequest : IRequestModel
    {
        public string CardNo { get; set; }
        public int Expiry { get; set; }
        public int Currency { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public bool Ecommerce { get; set; }
    }


}
