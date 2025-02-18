namespace TPS.Patterns.Factory_Method
{
    // PaymentProcessor class handles the payment process
    // It uses a factory to dynamically select the right payment provider 
    public class PaymentProcessor
    {
        private readonly PaymentGatewayFactory _gatewayFactory;

        // Constructor that takes a PaymentGatewayFactory (which is responsible for creating payment gateways)
        public PaymentProcessor(PaymentGatewayFactory gatewayFactory)
        {
            _gatewayFactory = gatewayFactory;
        }

        // Method to process the payment by selecting the correct payment provider
        public ResProcessPayment ProcessPayment(PaymentMethod paymentMethod, decimal amount)
        {
            // Use the factory to create the appropriate payment gateway based on the payment method
            var paymentGateway = _gatewayFactory.CreatePaymentGateway(paymentMethod);

            // Call the ProcessPayment method of the selected payment gateway to process the transaction
            var remarks = paymentGateway.ProcessPayment(amount);

            return new ResProcessPayment { 
                Remarks = remarks ,
                Status = "Success"
            };
        }
    }

}
