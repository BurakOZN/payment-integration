namespace PaymentIntegration.Model
{
    public class PaymentResponse<T>
    {
        /// <summary>
        /// Payment state. Please check this value and read result.
        /// </summary>
        public PaymentState State { get; set; }
        public T Result { get; set; }
    }
    public enum PaymentState
    {
        Error = 0,
        Success = 1,
    }
}
