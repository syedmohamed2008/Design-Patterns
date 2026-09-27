using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Services;

namespace FactoryDesignPattern.Notification
{
    public class SmsNotification : INotification
    {
        private readonly SmsService _smsService;
        private readonly string _mobile;

        public SmsNotification(
            SmsService smsService,
            string mobile)
        {
            _smsService = smsService;
            _mobile = mobile;
        }

        public void Send(string message)
        {
            _smsService.SendSms(_mobile, message);
        }
    }
}
