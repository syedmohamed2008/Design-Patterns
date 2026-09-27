namespace FactoryDesignPattern.Services
{
    public class SmsService
    {
        public void SendSms(string mobile, string message)
        {
            Console.WriteLine($"SMS sent to: {mobile}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
