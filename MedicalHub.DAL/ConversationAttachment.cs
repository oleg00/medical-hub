namespace MedicalHub.DAL;

public class ConversationAttachment
{
    public Guid Id { get; set; }
    public ConversationMessage Message { get; set; }
    public string Name { get; set; }
    public string DataUrl { get; set; }
    public DateTime UploadedOn { get; set; }
}

