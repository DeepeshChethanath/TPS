using Microsoft.AspNetCore.Mvc;
using TPS.Patterns.Factory_Method;
using Serilog;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace TPS.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TPSController(Serilog.ILogger logger) : ControllerBase
    {
        private readonly Serilog.ILogger _logger = logger;

        [HttpPost]
        [Route("ProcessPay")]
        public IActionResult ProcessPayment(ReqProcessPayment processPayment)
        {
            ResProcessPayment response;
            _logger.Information(JsonSerializer.Serialize(processPayment));
            try
            {
                PaymentMethod paymentGatewayEnum = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), processPayment.PaymentGateway);
                // Create an instance of the PaymentGatewaySelector factory
                var gatewayFactory = new PaymentGatewaySelector();

                // Create a PaymentProcessor using the factory
                var paymentProcessor = new PaymentProcessor(gatewayFactory);
                response = paymentProcessor.ProcessPayment(paymentGatewayEnum, processPayment.Amount);
                
            }
            catch (ArgumentException)
            {
                response = new ResProcessPayment { Status = "Failure", Remarks = "Unsupported payment method." };
                _logger.Error("Unsupported payment method.");
            }
            _logger.Information(JsonSerializer.Serialize(response));
            return Ok(response);
        }
    }
}
