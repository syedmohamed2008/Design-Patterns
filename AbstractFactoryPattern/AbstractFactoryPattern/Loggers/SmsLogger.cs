using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Loggers
{
    public class SmsLogger : INotificationLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"SMS Log: {message}");
        }
    }
}
