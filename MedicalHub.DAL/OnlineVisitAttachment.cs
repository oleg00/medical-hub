namespace MedicalHub.DAL;

public class OnlineVisitAttachment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public byte[] Data { get; set; }
    public DateTime UploadedOn { get; set; }
}

