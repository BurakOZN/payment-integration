using System;

namespace PaymentIntegration.Model
{
    public class BatchCloseResponse
    {
        public string ResultMessage { get; set; }
        public string ResultCode { get; set; }
        public int BatchNo { get; set; }
        public DateTime ProcessDate { get; set; }
    }


}
