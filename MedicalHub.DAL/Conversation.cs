namespace MedicalHub.DAL;

public class Conversation
{
    public Guid Id { get; set; }
    public OnlineVisit OnlineVisit { get; set; }
    public DateTime StartedAt { get; set; }
}

