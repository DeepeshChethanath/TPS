# TPS
Transaction Processing API that showcases all creational design patterns while handling different financial services, such as payments, loans, investments, and reports.

>Singleton Design Pattern
Serilog is set up as a singleton logger that can be injected into any component using dependency injection.
Logs are written to both the console and a log file, with support for rolling logs daily.

>Factory Method Design Pattern
IPaymentGateway is an interface that defines a method for processing payments.
Concrete payment gateway classes (GPayPaymentGateway, PayTMPaymentGateway, RazorPayPaymentGateway) implement this interface.
The PaymentGatewayFactory abstract class provides a CreatePaymentGateway method that is implemented by the PaymentGatewaySelector to return the correct payment provider.
The PaymentProcessor class uses the factory to dynamically select and process payments based on the payment method.
