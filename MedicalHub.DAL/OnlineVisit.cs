namespace MedicalHub.DAL;

public class OnlineVisit
{
    public int Id { get; set; }
    public Contact Patient { get; set; }
    public int PatientId { get; set; }
    public Contact Doctor { get; set; }
    public int DoctorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Name { get; set; }
    public bool IsClosed { get; set; }
    public string? VisitResult { get; set; }
    public string CauseType { get; set; }
    public Conversation Conversation { get; set; }
    public OnlineVisitAttachment Attachment { get; set; }
}

