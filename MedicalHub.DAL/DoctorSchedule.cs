namespace MedicalHub.DAL;

public class DoctorSchedule
{
    public int Id { get; set; }
    public Doctor Doctor { get; set; }
    public int DoctorId { get; set; }
    public DateTime TimeStart { get; set; }
    public DateTime TimeEnd { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
}

