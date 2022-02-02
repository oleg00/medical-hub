namespace MedicalHub.DAL;

public class Conversation
{
    public int Id { get; set; }
    public Patient Patient { get; set; }
    public int PatientId { get; set; }
    public Doctor Doctor { get; set; }
    public int DoctorId { get; set; }
    public OnlineVisit OnlineVisit { get; set; }
    public DateTime StartedOn { get; set; }
    public List<ConversationMessage> ConversationMessages { get; set; }
}

