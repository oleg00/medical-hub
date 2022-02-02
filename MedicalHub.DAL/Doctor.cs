namespace MedicalHub.DAL
{
    public class Doctor
    {
        public int Id { get; set; }
        public Education Education { get; set; }
        public DoctorCategory DoctorCategory { get; set; }
        public List<DoctorFeedback> DoctorFeedbacks { get; set; }
        public double VisitPrice { get; set; }
    }
}
