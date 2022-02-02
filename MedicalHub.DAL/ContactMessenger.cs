namespace MedicalHub.DAL
{
    public class ContactMessenger
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
        public MessengerType MessengerType { get; set; }
        public int MessengerTypeId { get; set; }

    }
}
