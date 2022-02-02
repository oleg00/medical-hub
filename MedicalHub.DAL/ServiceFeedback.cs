namespace MedicalHub.DAL
{
    public class ServiceFeedback
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
        public int Rate { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
