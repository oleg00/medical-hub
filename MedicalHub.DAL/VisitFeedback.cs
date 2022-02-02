namespace MedicalHub.DAL
{
    public class VisitFeedback
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
        public double Rate { get; set; }
    }
}
