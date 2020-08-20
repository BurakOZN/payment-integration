using PaymentIntegration.Model;

namespace PaymentIntegration.Model
{
    public class CheckPaymentRequest : IRequestModel
    {
        public string Token { get; set; }
    }
}
