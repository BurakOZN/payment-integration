using System;

namespace PaymentIntegration.Model
{
    public class PointInquiryResponse
    {
        public string ResultMessage { get; set; }
        public string ResultCode { get; set; }
        public string CardMask { get; set; }
        public decimal AvailablePoint { get; set; }
        public DateTime ProcessDate { get; set; }
    }


}
