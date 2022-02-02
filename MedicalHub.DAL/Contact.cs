namespace MedicalHub.DAL
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ContactMessenger ContactMessenger { get; set; }
        public int ContactMessengerId { get; set; }
        public string ImageUrl { get; set; }
    }
}
