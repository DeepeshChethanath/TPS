namespace TPS.Patterns.Factory_Method.Interface
{
    // This is the interface that all payment providers must implement.
    // It ensures that all payment providers (e.g., GPay, RazorPay, PayTM, Billdesk) will have a `ProcessPayment` method.
    public interface IPaymentGateway
    {
        string ProcessPayment(decimal amount);  // This method processes a payment of a given amount.
    }


}
