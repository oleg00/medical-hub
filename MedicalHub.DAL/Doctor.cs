namespace MedicalHub.DAL
{
    public class Doctor
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
        public List<Education> Educations { get; set; }
        public List<DoctorCategory> DoctorCategories { get; set; }
        public List<DoctorFeedback> DoctorFeedbacks { get; set; }
        public double VisitPrice { get; set; }
    }
}
