using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Component Interface
    public interface INotificationService
    {
        void Send(string message);
    }


    // Concrete Component
    public class NotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }


    // Decorator
    public class LoggingNotificationDecorator : INotificationService
    {
        private readonly INotificationService _notificationService;

        public LoggingNotificationDecorator(
            INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Send(string message)
        {
            Console.WriteLine("Log: Sending notification...");

            _notificationService.Send(message);

            Console.WriteLine("Log: Notification sent successfully.");
        }
    }


    public class TimingNotificationDecorator : INotificationService
    {
        private readonly INotificationService _notificationService;

        public TimingNotificationDecorator(
            INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Send(string message)
        {
            var stopwatch = Stopwatch.StartNew();

            _notificationService.Send(message);

            stopwatch.Stop();

            Console.WriteLine(
                $"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }


    // Program
    public class Program
    {
        public static void Main()
        {
            // Original service
            INotificationService notification = new NotificationService();

            // Wrap original service with decorator
            notification = new LoggingNotificationDecorator(notification);

            // Wrap original service with decorator
            notification =new TimingNotificationDecorator(notification);

            // Call decorator
            notification.Send("Your order has been confirmed.");
        }
    }
}
