using Shared.Models.Notifications.Enums;

namespace Shared.Models.Notifications
{
    /// <summary>
    /// Push notification specific message
    /// </summary>
    public class PushNotificationMessage : NotificationMessage
    {
        public override NotificationType NotificationType => NotificationType.PushNotification;
        public string DeviceToken { get; set; } = string.Empty;
        public string? Title { get; set; }
        public Dictionary<string, string>? Data { get; set; }
    }
}
