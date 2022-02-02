namespace MedicalHub.DAL
{
    public class Patient
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
    }
}
