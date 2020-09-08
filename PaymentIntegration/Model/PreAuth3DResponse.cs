namespace PaymentIntegration.Model
{
    public class PreAuth3DResponse
    {
        public string HtmlContent { get; set; }
        public string ProcessId { get; set; }
        public string OrderId { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}
