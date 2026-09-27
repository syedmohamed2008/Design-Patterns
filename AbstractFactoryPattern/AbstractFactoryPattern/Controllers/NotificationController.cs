namespace AbstractFactoryPattern.Controllers
{
    using AbstractFactoryPattern.Factories;
    using AbstractFactoryPattern.Model;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationFactoryProvider _factoryProvider;

        public NotificationController(NotificationFactoryProvider factoryProvider)
        {
            _factoryProvider = factoryProvider;
        }

        [HttpPost]
        public IActionResult Send(NotificationRequest request)
        {
            var factory = _factoryProvider.GetFactory(request.Type);

            var notification = factory.CreateNotification();

            var logger = factory.CreateLogger();

            notification.Send(request.Message);

            logger.Log($"{request.Type} notification sent successfully.");

            return Ok(new
            {
                Message = "Notification sent successfully"
            });
        }
    }
}
