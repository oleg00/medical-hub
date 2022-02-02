namespace MedicalHub.DAL;

public class OnlineVisitAttachment
{
    public int Id { get; set; }
    public OnlineVisit OnlineVisit { get; set; }
    public int OnlineVisitId { get; set; }
    public string Name { get; set; }
    public string DataUrl { get; set; }
    public DateTime UploadedOn { get; set; }
}

