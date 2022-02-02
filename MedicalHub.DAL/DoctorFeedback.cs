namespace MedicalHub.DAL
{
    public class DoctorFeedback
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public double Rate { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
