using Shared.Models.Notifications.Enums;

namespace Shared.Models.Notifications
{
    /// <summary>
    /// Email specific notification message
    /// </summary>
    public class EmailNotificationMessage : NotificationMessage
    {
        public override NotificationType NotificationType => NotificationType.Email;
        public string EmailAddress { get; set; } = string.Empty;
        public List<string>? CcList { get; set; }
        public List<string>? BccList { get; set; }
        public List<Attachment>? Attachments { get; set; }
    }
}
