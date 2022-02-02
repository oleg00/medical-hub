namespace MedicalHub.DAL
{
    public class DoctorCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
