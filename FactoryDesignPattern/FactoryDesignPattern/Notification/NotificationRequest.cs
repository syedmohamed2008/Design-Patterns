namespace FactoryDesignPattern.Notification
{
    public class NotificationRequest
    {
        public string Type { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
    }
}
