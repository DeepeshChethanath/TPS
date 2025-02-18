using TPS.Patterns.Factory_Method.Interface;

namespace TPS.Patterns.Factory_Method
{
    // Abstract factory class that defines the method to create payment gateways
    // This class will be inherited by concrete factory classes (like PaymentGatewaySelector)
    public abstract class PaymentGatewayFactory
    {
        // Abstract method for creating the payment gateway. 
        // Concrete factories will provide the implementation for this method.
        public abstract IPaymentGateway CreatePaymentGateway(PaymentMethod paymentMethod);
    }
}
