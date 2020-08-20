using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaymentIntegration.Helper
{
    public class ApiConnection
    {
        public static readonly ApiConnection Instance = new ApiConnection();
        private static readonly HttpClient _client;

        static ApiConnection()
        {
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            _client = new HttpClient();
        }
        private ApiConnection()
        {
        }

        private void SetHeader(HttpRequestMessage httpRequestMessage, Dictionary<string, string> _headers)
        {
            foreach (var header in _headers)
            {
                httpRequestMessage.Headers.Add(header.Key, header.Value);
            }
        }

        public async Task<ConnectionResponseModel<T>> Post<T>(string url, object content, Dictionary<string, string> _headers, bool useEncryption = false, string encryptionPassword = "") where T : class
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            var contentString = JsonConvert.SerializeObject(content);
            if (useEncryption)
                contentString = Encryption.Encrypt(contentString, encryptionPassword);
            request.Content = new StringContent(contentString, Encoding.UTF8, "application/json");
            if (_headers != null)
                SetHeader(request, _headers);
            return await SendAsync<T>(request);
        }

        private async Task<ConnectionResponseModel<T>> SendAsync<T>(HttpRequestMessage request) where T : class
        {
            HttpResponseMessage response;
            try
            {
                response = await _client.SendAsync(request);
            }
            catch (Exception ex)
            {
                return new ConnectionResponseModel<T>() { IsSuccess = false, StatusCode = 0 };
            }

            if (response.IsSuccessStatusCode)
            {
                var stringRead = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(stringRead);
                return new ConnectionResponseModel<T>() { IsSuccess = true, Result = result, StatusCode = response.StatusCode };
            }
            else
            {
                return new ConnectionResponseModel<T>() { IsSuccess = false, StatusCode = response.StatusCode };
            }
        }
    }
    public class ConnectionResponseModel<T>
    {
        /// <summary>
        /// StatusCode:200
        /// </summary>
        public bool IsSuccess { get; set; }
        public T Result { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
