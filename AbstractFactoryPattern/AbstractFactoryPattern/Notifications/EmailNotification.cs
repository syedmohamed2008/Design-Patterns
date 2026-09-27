using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
