namespace PaymentIntegration.Model
{
    public class PaymentOptions
    {
        public PaymentOptions(string baseUrl, string apiKey, string secretKey, bool useEncryption = false, string encryptionPassword = "")
        {
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
            UseEncryption = useEncryption;
            EncryptionPassword = encryptionPassword;
        }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string BaseUrl { get; set; }
        public string EncryptionPassword { get; set; }
        public bool UseEncryption { get; set; }
    }
}
