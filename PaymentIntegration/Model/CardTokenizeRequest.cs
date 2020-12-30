using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentIntegration.Model
{
    public class CardTokenizeRequest:IRequestModel
    {
        public string CardNo { get; set; }
    }
}
