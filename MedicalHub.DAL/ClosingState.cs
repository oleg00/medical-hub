namespace MedicalHub.DAL;

/// <summary>
/// Thread automatic closing state model.
/// ByNeed, ByTimeout or ByMaxMessageCount.
/// </summary>
public class ThreadClosingState
{

    public int Id { get; set; }
    public string Name { get; set; }
    
}