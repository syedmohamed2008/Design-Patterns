namespace FactoryDesignPattern.Services
{
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email sent to: {email}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
