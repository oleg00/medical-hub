namespace MedicalHub.DAL
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Level { get; set; }
        public string ConfirmationDocumentUrl { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
