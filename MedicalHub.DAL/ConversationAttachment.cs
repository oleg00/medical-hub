namespace MedicalHub.DAL;

public class ConversationAttachment
{
    public int Id { get; set; }
    public ConversationMessage Message { get; set; }
    public int MessageId { get; set; }
    public string Name { get; set; }
    public string DataUrl { get; set; }
    public DateTime UploadedOn { get; set; }
}

