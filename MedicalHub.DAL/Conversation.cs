namespace MedicalHub.DAL;

public class Conversation
{
    public int Id { get; set; }
    public Contact Patient { get; set; }
    public int PatientId { get; set; }
    public Contact Doctor { get; set; }
    public int DoctorId { get; set; }
    public OnlineVisit OnlineVisit { get; set; }
    public DateTime StartedAt { get; set; }
    public List<ConversationMessage> ConversationMessages { get; set; }
}

