namespace PaymentIntegration.Model
{
    public class PaymentOptions
    {
        public PaymentOptions(string baseUrl, string apiKey, string secretKey)
        {
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
        }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string BaseUrl { get; set; }
    }
}
