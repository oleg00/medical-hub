namespace MedicalHub.DAL;

/// <summary>
/// <see cref="Thread"/> request from a patient.
/// </summary>
public class ThreadRequest
{

    public int Id { get; set; }

    public Thread Thread { get; set; }
    public int ThreadId { get; set; }
    
    public Patient Patient { get; set; }
    public int PatientId { get; set; }

    public Doctor Doctor { get; set; }
    public int DoctorId { get; set; }

    public bool IsApproved { get; set; }
    
}