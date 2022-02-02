namespace MedicalHub.DAL;

public class ConversationMessage
{
    public int Id { get; set; }
    public Conversation Conversation { get; set; }
    public int ConversationId { get; set; }
    public DateTime Timestamp { get; set; }
    public string MessageText { get; set; }
    public List<ConversationAttachment> ConversationAttachments { get; set; }
}

