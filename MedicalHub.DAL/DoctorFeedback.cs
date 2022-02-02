namespace MedicalHub.DAL
{
    public class DoctorFeedback
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public double Rate { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
