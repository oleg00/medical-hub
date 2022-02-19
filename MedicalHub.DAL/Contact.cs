using MedicalHub.DAL.Enumerations;

namespace MedicalHub.DAL
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        public List<ContactMessenger> ContactMessengers { get; set; }
        public string ImageUrl { get; set; }
        public ContactType ContactType { get; set; }
        public int ContactTypeId { get; set; }
    }
}
