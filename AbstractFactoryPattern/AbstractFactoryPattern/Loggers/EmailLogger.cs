using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Loggers
{
    public class EmailLogger : INotificationLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Email Log: {message}");
        }
    }
}
