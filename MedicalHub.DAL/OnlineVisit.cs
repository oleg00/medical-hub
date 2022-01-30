namespace MedicalHub.DAL;

public class OnlineVisit
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Name { get; set; }
    public bool IsClosed { get; set; }
    public string? VisitResult { get; set; }
    public string CauseType { get; set; }
}

