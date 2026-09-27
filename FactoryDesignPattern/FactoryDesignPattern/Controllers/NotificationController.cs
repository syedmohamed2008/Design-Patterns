using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Notification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationFactory _factory;

        public NotificationController(INotificationFactory factory)
        {
            _factory = factory;
        }

        [HttpPost]
        public IActionResult Send(NotificationRequest request)
        {
            INotification notification = _factory.CreateNotification(request);

            notification.Send(request.Message);

            return Ok("Notification sent successfully");
        }
    }
}
