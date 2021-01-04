# Using the Payment-Integration Library for .Net Framework and .Net Core

Supports .NET Framework, .NET Core 1.1, .NET Core 2.0 runtimes, .NET Core 2.1 runtimes
## Installation
[![NuGet](https://img.shields.io/nuget/v/paymentintegration.svg)](https://www.nuget.org/packages/PaymentIntegration)

To install Payment Integration, run the following command in the Package Manager Console

```
Install-Package PaymentIntegration
```
https://www.nuget.org/packages/PaymentIntegration

# Usage
### Auth

```csharp
//For security
var paymentOptions = new PaymentOptions(
                "url",
                "yourApiKey",
                "yourSecretKey");
                
AuthRequest req = new AuthRequest();
authReq.Amount = 2;
authReq.CardNo = "1111111111111111";
authReq.Currency = 978;
authReq.Cvv2 = "111";
authReq.Ecommerce = true;
authReq.Expiry = YYMM;
authReq.Lang = "TR";
authReq.OrderId = "123"; //must be uniq

Payment paymentManager = new Payment(paymentOptions);
var payment = await paymentManager.Auth(authReq);
```
### Auth3D

```csharp
var paymentOptions = new PaymentOptions(
                "url",
                "yourApiKey",
                "yourSecretKey");
                
var auth3DRequest = new Auth3DRequest();
auth3DRequest.Amount = 500;//5.00
auth3DRequest.CardNo = "1122112211221122";
auth3DRequest.Currency = 978;
auth3DRequest.Cvv2 = "123";
auth3DRequest.Ecommerce = true;
auth3DRequest.Expiry = 2408;//YYMM
auth3DRequest.InstallmentCount = 1;
auth3DRequest.Lang = "TR";
auth3DRequest.OrderId = DateTime.Now.Ticks.ToString();

var payment = new Payment(paymentOptions);
var response = await payment.Auth3D(auth3DRequest);
if (response.IsConnectionSuccess)//StatusCode=200
  if (response.Result.State == PaymentState.Success)
  {
    var html64 = response.Result.Result.HtmlContent;
    var htmlContent = Encoding.UTF8.GetString(Convert.FromBase64String(html64));
    return Content(htmlContent, "text/html");
  }
  else
    return View(new ErrorViewModel() { ErrorMessage = response.Result.Result.ResultMessage });
return View(new ErrorViewModel() { ErrorMessage = "Connection Error:" + response.StatusCode });
            
            
The return url should receive the token and reach the payment result by checking.
Example MVC;
public async Task<IActionResult> Index(string token)
{
  var paymentOptions = new PaymentOptions(
                  "url",
                  "yourApiKey",
                  "yourSecretKey");
                  
  Payment paymentManager = new Payment(paymentOptions);
  var checkReq=new CheckPaymentRequest() { Token = token }
  var checkResp = await paymentManager.CheckPayment(checkReq);
  //you can save response data or show your screen
}
```
### Use Encryption
If you want the request to be encrypted
```csharp
var paymentOptions = new PaymentOptions(
                "url",
                "yourApiKey",
                "yourSecretKey",
                true,
                "yourEncryptionPassword");
```
Example UI (.Net5 MVC) project https://github.com/BurakOZN/payment-integration-example
