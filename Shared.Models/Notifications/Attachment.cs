namespace Shared.Models.Notifications
{
    /// <summary>
    /// Email attachment model
    /// </summary>
    public class Attachment
    {
        public string FileName { get; set; } = string.Empty;
        public byte[] Content { get; set; } = [];
        public string ContentType { get; set; } = string.Empty;
    }
}
