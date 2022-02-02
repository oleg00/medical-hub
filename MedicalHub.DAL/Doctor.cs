namespace MedicalHub.DAL
{
    public class Doctor
    {
        public int Id { get; set; }
        public Education Education { get; set; }
        public int EducationId { get; set; }
        public DoctorCategory DoctorCategory { get; set; }
        public int DoctorCategoryId { get; set; }
        public List<DoctorFeedback> DoctorFeedbacks { get; set; }
        public double VisitPrice { get; set; }
    }
}
