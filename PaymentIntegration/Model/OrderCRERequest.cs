using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentIntegration.Model
{
    public class OrderCRERequest : IRequestModel
    {
        public int Currency { get; set; }
        public long Amount { get; set; }
        public string OrderId { get; set; }
        public string Lang { get; set; }
    }
}
