namespace MedicalHub.DAL
{
    public class Visit
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public VisitFeedback VisitFeedback { get; set; }
        public int VisitFeedBackId { get; set; }
    }
}
