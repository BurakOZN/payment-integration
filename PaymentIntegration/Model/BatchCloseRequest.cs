namespace PaymentIntegration.Model
{
    public class BatchCloseRequest : IRequestModel
    {
        public int BatchNo { get; set; }
        public int Currency { get; set; }
        public string Lang { get; set; }
    }


}
