namespace FactoryDesignPattern.Services
{
    public class WhatsAppService
    {
        public void SendWhatsApp(string mobile, string message)
        {
            Console.WriteLine($"WhatsApp sent to: {mobile}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
