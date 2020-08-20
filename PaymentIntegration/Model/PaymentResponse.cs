using System.Net;

namespace PaymentIntegration.Manager
{

    public class ConnectionResponse<T>
    {
        public bool IsConnectionSuccess { get; set; }
        public T Result { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
