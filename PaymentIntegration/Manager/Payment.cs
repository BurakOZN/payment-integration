﻿using PaymentIntegration.Helper;
using PaymentIntegration.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentIntegration.Manager
{
    public class Payment
    {
        public Payment(PaymentOptions PaymentOptions)
        {
            this.PaymentOptions = PaymentOptions;
        }
        public PaymentOptions PaymentOptions { get; set; }
        /// <summary>
        /// Sale
        /// Satış
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<AuthResponse>>> Auth(AuthRequest requestModel)
        {
            return await PaymentOperation<AuthResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/Auth");
        }
        /// <summary>
        /// Pre Sale
        /// Ön Satış
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<PreAuthResponse>>> PreAuth(PreAuthRequest requestModel)
        {
            return await PaymentOperation<PreAuthResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/PreAuth");
        }
        /// <summary>
        /// Post Sale
        /// Ön Satış Kapama
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<PointAuthResponse>>> PointAuth(PointAuthRequest requestModel)
        {
            return await PaymentOperation<PointAuthResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/PointAuth");
        }
        /// <summary>
        /// Point Sale
        /// Puanlı Satış
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<PostAuthResponse>>> PostAuth(PostAuthRequest requestModel)
        {
            return await PaymentOperation<PostAuthResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/PostAuth");
        }
        /// <summary>
        /// Void
        /// İptal
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<VoidResponse>>> Void(VoidRequest requestModel)
        {
            return await PaymentOperation<VoidResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/Void");
        }
        /// <summary>
        /// Refund
        /// İade
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<RefundResponse>>> Refund(RefundRequest requestModel)
        {
            return await PaymentOperation<RefundResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/Refund");
        }
        /// <summary>
        /// Point Inquiry
        /// Puan Sorgulama
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<PointInquiryResponse>>> PointInquiry(PointInquiryRequest requestModel)
        {
            return await PaymentOperation<PointInquiryResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/PointInquiry");
        }
        /// <summary>
        /// Batch Close
        /// Batch Kapama
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<BatchCloseResponse>>> BatchClose(BatchCloseRequest requestModel)
        {
            return await PaymentOperation<BatchCloseResponse>(PaymentOptions, requestModel, "/api/v1/NonSecure/BatchClose");
        }
        /// <summary>
        /// 3D Sale
        /// 3D Satış
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<Auth3DResponse>>> Auth3D(Auth3DRequest requestModel)
        {
            return await PaymentOperation<Auth3DResponse>(PaymentOptions, requestModel, "/api/v1/ThreeD/ThreeDModelAuth");
        }
        /// <summary>
        /// 3D Pre Sale
        /// 3D Ön Satış
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<PreAuth3DResponse>>> PreAuth3D(PreAuth3DRequest requestModel)
        {
            return await PaymentOperation<PreAuth3DResponse>(PaymentOptions, requestModel, "/api/v1/ThreeD/ThreeDModelPreAuth");
        }
        /// <summary>
        /// Check Payment
        /// 3D Ödeme Kontrol
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<CheckPaymentResponse>>> CheckPayment(CheckByTokenRequest requestModel)
        {
            return await PaymentOperation<CheckPaymentResponse>(PaymentOptions, requestModel, "/api/v1/ThreeD/CheckPayment");
        }
        public async Task<ConnectionResponse<PaymentResponse<CheckPaymentResponse>>> CheckByProcessId(CheckByProcessIdRequest requestModel)
        {
            return await PaymentOperation<CheckPaymentResponse>(PaymentOptions, requestModel, "/api/Check/ByProcessId");
        }
        public async Task<ConnectionResponse<PaymentResponse<CheckPaymentResponse>>> CheckOrderId(CheckByOrderIdRequest requestModel)
        {
            return await PaymentOperation<CheckPaymentResponse>(PaymentOptions, requestModel, "/api/Check/ByOrderId");
        }
        public async Task<ConnectionResponse<PaymentResponse<CheckPaymentResponse>>> CheckByToken(CheckByTokenRequest requestModel)
        {
            return await PaymentOperation<CheckPaymentResponse>(PaymentOptions, requestModel, "/api/Check/ByToken");
        }
        public async Task<ConnectionResponse<PaymentResponse<CheckPaymentResponse>>> Complete3D(Complete3DRequest requestModel)
        {
            return await PaymentOperation<CheckPaymentResponse>(PaymentOptions, requestModel, "/api/v1/ThreeD/Complete3D");
        }
        public async Task<ConnectionResponse<PaymentResponse<CardTokenizeResponse>>> CardEncrypted(CardTokenizeRequest requestModel)
        {
            return await PaymentOperation<CardTokenizeResponse>(PaymentOptions, requestModel, "/api/Card/Encrypted");
        }
        public async Task<ConnectionResponse<PaymentResponse<CardTokenizeResponse>>> CardDecrypted(CardTokenizeRequest requestModel)
        {
            return await PaymentOperation<CardTokenizeResponse>(PaymentOptions, requestModel, "/api/Card/Decrypted");
        }
         public async Task<ConnectionResponse<PaymentResponse<OrderCreateResponse>>> CreateOrder(OrderCreateRequest requestModel)
        {
            return await PaymentOperation<OrderCreateResponse>(PaymentOptions, requestModel, "/api/v1/Order/CreateOrder");
        }
        public async Task<ConnectionResponse<PaymentResponse<OrderCreateResponse>>> CreateOrder3D(OrderCreateRequest requestModel)
        {
            return await PaymentOperation<OrderCreateResponse>(PaymentOptions, requestModel, "/api/v1/Order/CreateOrder3D");
        }
        /// <summary>
        /// Create NonSecure Order Transaction
        /// Satış İşlemi Oluşturma (Ortak Ödeme Ekranı)
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<OrderCREResponse>>> CreateOrder(OrderCRERequest requestModel)
        {
            return await PaymentOperation<OrderCREResponse>(PaymentOptions, requestModel, "/api/v1/Order/CreateOrder");
        }
        /// <summary>
        /// Create 3D Auth Order Transaction
        /// 3D Satış Oluşturma (Ortak Ödeme Ekranı)
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<OrderCREResponse>>> CreateOrder3D(OrderCRERequest requestModel)
        {
            return await PaymentOperation<OrderCREResponse>(PaymentOptions, requestModel, "/api/v1/Order/CreateOrder3D");
        }
        /// <summary>
        /// Check Order URL
        /// Sipariş URL Kontrolü
        /// </summary>
        public async Task<ConnectionResponse<PaymentResponse<OrderCHResponse>>> OrderCH(string pk)
        {

            return await PaymentOperation<OrderCHResponse>(PaymentOptions, "/api/v1/Order/CheckOrder?pk="+pk);
        }
        public async Task<ConnectionResponse<PaymentResponse<OrderCMResponse>>> OrderCM(OrderCMRequest requestModel)
        {
            return await PaymentOperation<OrderCMResponse>(PaymentOptions, requestModel, "/api/v1/Order/CompleteOrderAuth");
        }
        public async Task<ConnectionResponse<PaymentResponse<Auth3DResponse>>> OrderTCM(OrderTCMRequest requestModel)
        {
            return await PaymentOperation<Auth3DResponse>(PaymentOptions, requestModel, "/api/v1/Order/CompleteOrderThreeDAuth");
        }

        private async Task<ConnectionResponse<PaymentResponse<T>>> PaymentOperation<T>(PaymentOptions PaymentOptions, IRequestModel requestModel, string apiUrl)
        {
            var header = new Dictionary<string, string>();
            header.Add("api_key", PaymentOptions.ApiKey);
            header.Add("secret_key", PaymentOptions.SecretKey);
            var authResponse = await ApiConnection.Instance.Post<PaymentResponse<T>>(PaymentOptions.BaseUrl + apiUrl, requestModel, header, PaymentOptions.UseEncryption, PaymentOptions.EncryptionPassword);
            var payResponse = new ConnectionResponse<PaymentResponse<T>>();
            if (!authResponse.IsSuccess)
            {
                payResponse.StatusCode = authResponse.StatusCode;
                return payResponse;
            }
            payResponse.IsConnectionSuccess = true;
            payResponse.Result = authResponse.Result;
            return payResponse;
        }

        private async Task<ConnectionResponse<PaymentResponse<T>>> PaymentOperation<T>(PaymentOptions PaymentOptions, string apiUrl)
        {
            var header = new Dictionary<string, string>();
            header.Add("api_key", PaymentOptions.ApiKey);
            header.Add("secret_key", PaymentOptions.SecretKey);
            var authResponse = await ApiConnection.Instance.Get<PaymentResponse<T>>(PaymentOptions.BaseUrl + apiUrl, header);
            var payResponse = new ConnectionResponse<PaymentResponse<T>>();
            if (!authResponse.IsSuccess)
            {
                payResponse.StatusCode = authResponse.StatusCode;
                return payResponse;
            }
            payResponse.IsConnectionSuccess = true;
            payResponse.Result = authResponse.Result;
            return payResponse;
        }
    }
}
