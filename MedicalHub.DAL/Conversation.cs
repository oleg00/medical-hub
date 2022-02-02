namespace MedicalHub.DAL;

public class Conversation
{
    public Guid Id { get; set; }
    public Contact Patient { get; set; }
    public Contact Doctor { get; set; }
    public OnlineVisit OnlineVisit { get; set; }
    public DateTime StartedAt { get; set; }
}

