using Shared.Models.Notifications.Enums;

namespace Shared.Models.Notifications
{
    /// <summary>
    /// Base model for all notification messages
    /// </summary>
    public abstract class NotificationMessage
    {
        public string MessageId { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public abstract NotificationType NotificationType { get; }
        public string Recipient { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int? ClientId { get; set; }
        public Dictionary<string, object> Metadata { get; set; } = [];
    }
}
