using TPS.Patterns.Factory_Method.ConcreteClasses;
using TPS.Patterns.Factory_Method.Interface;

namespace TPS.Patterns.Factory_Method
{
    // This is the concrete factory that creates instances of specific payment gateways
    public class PaymentGatewaySelector : PaymentGatewayFactory
    {
        // Based on the PaymentMethod, return the appropriate payment gateway
        public override IPaymentGateway CreatePaymentGateway(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.GPay:
                    return new GPayPaymentGateway();  // Return PayPal payment gateway
                case PaymentMethod.RazorPay:
                    return new RazorPayPaymentGateway();  // Return Stripe payment gateway
                case PaymentMethod.PayTM:
                    return new PayTMPaymentGateway();  // Return Credit Card payment gateway
                default:
                    throw new InvalidOperationException("Unsupported payment method.");  // Error if the method is unknown
            }
        }
    }

}
