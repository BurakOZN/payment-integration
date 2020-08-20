using System;

namespace PaymentIntegration.Model
{
    public class CheckPaymentResponse
    {
        public byte Eci { get; set; }
        public string Cavv { get; set; }
        public string Xid { get; set; }
        public string TxnStatus { get; set; }
        public int MdStatus { get; set; }
        public string ProcessId { get; set; }
        public string OrderId { get; set; }
        public string ResultMessage { get; set; }
        public string ResultCode { get; set; }
        public string ProcReturnCode { get; set; }
        public string AuthCode { get; set; }
        public string SecureType { get; set; }
        public string TxnType { get; set; }
        public string CardMask { get; set; }
        public long Amount { get; set; }
        public string MerchantId { get; set; }
        public string TerminalId { get; set; }
        public int BatchNo { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
