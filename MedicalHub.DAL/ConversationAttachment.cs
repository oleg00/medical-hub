namespace MedicalHub.DAL;

public class ConversationAttachment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public byte[] Data { get; set; }
    public DateTime UploadedOn { get; set; }
}

