namespace MedicalHub.DAL;

/// <summary>
/// Thread automatic closing state model.
/// ByNeed, ByTimeout or ByMaxMessageCount.
/// </summary>
public class ThreadClosingState
{

    public Guid Id { get; set; }
    public string Name { get; set; }
    
}