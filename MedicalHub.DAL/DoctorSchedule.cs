namespace MedicalHub.DAL;

public class DoctorSchedule
{
    public int Id { get; set; }
    public Contact Doctor { get; set; }
    public int DoctorId { get; set; }
    public TimeOnly TimeStart { get; set; }
    public TimeOnly TimeEnd { get; set; }
    public DateOnly DateStart { get; set; }
    public DateOnly DateEnd { get; set; }
}

