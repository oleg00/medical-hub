namespace MedicalHub.DAL;

public class ConversationMessage
{
    public Guid Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string MessageText { get; set; }
}

