using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Services;

namespace FactoryDesignPattern.Notification
{
    public class WhatsAppNotification : INotification
    {
        private readonly WhatsAppService _whatsAppService;
        private readonly string _mobile;

        public WhatsAppNotification(
            WhatsAppService whatsAppService,
            string mobile)
        {
            _whatsAppService = whatsAppService;
            _mobile = mobile;
        }

        public void Send(string message)
        {
            _whatsAppService.SendWhatsApp(
                _mobile,
                message);
        }
    }
}
