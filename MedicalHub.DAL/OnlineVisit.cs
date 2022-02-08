namespace MedicalHub.DAL;

public class OnlineVisit
{
    public int Id { get; set; }
    public Patient Patient { get; set; }
    public int PatientId { get; set; }
    public Doctor Doctor { get; set; }
    public int DoctorId { get; set; }
    public Thread Thread { get; set; }
    public int ThreadId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Name { get; set; }
    public bool IsClosed { get; set; }
    public string? VisitResult { get; set; }
    public string CauseType { get; set; }
}

