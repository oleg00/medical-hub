namespace MedicalHub.DAL;

public class ConversationMessage
{
    public Guid Id { get; set; }
    public Conversation Conversation { get; set; }
    public DateTime Timestamp { get; set; }
    public string MessageText { get; set; }
}

