using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentIntegration.Model
{
    public abstract class ThreeDResponse
    {
        public string HtmlContent { get; set; }
        public string ProcessId { get; set; }
        public string OrderId { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string Token { get; set; }
        public ThreeDPaymentHtmlResponse HtmlResponse { get; set; }
    }
    public class ThreeDPaymentHtmlResponse
    {
        public string AcsUrl { get; set; }
        public string PAReq { get; set; }
        public string TermUrl { get; set; }
        public string MD { get; set; }
    }
}
