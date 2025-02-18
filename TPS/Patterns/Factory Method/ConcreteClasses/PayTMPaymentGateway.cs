using TPS.Patterns.Factory_Method.Interface;

namespace TPS.Patterns.Factory_Method.ConcreteClasses
{
    public class PayTMPaymentGateway : IPaymentGateway
    {
        public string ProcessPayment(decimal amount)
        {
            return new string($"Processing payment of Rs {amount} via PayTM.");
        }
    }
}
