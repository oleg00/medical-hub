namespace MedicalHub.DAL
{
    public class VisitFeedback
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int VisitId { get; set; }
        public Visit Visit { get; set; }
        public int Rate { get; set; }
    }
}
