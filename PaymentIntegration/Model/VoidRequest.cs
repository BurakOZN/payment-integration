namespace PaymentIntegration.Model
{
    public class VoidRequest : IRequestModel
    {
        public string ProcessId { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
        public bool Ecommerce { get; set; }
    }


}
