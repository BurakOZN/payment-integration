using PaymentIntegration.Model;

namespace PaymentIntegration.Model
{
    public class CheckByTokenRequest : IRequestModel
    {
        public string Token { get; set; }
        public string Lang { get; set; }
    }
    public class CheckByProcessIdRequest : IRequestModel
    {
        public string ProcessId { get; set; }
        public string Lang { get; set; }
    }
    public class CheckByOrderIdRequest : IRequestModel
    {
        public string OrderId { get; set; }
        public string Lang { get; set; }
    }
    //1.7
    public class CheckPaymentRequest : CheckByTokenRequest
    {

    }
}
