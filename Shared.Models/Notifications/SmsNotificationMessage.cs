using Shared.Models.Notifications.Enums;

namespace Shared.Models.Notifications
{
    /// <summary>
    /// SMS specific notification message
    /// </summary>
    public class SmsNotificationMessage : NotificationMessage
    {
        public override NotificationType NotificationType => NotificationType.Sms;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
    }
}
