namespace MedicalHub.DAL;

/// <summary>
/// Chat thread model.
/// </summary>
public class Thread
{
    
    public int Id { get; set; }
    
    /// <summary>
    /// Thread created DateTime.
    /// </summary>
    public DateTime CreatedDate { get; set; }
    
    /// <summary>
    /// Thread closed DateTime.
    /// </summary>
    public DateTime ClosedDate { get; set; }

    /// <summary>
    /// Patient who started thread.
    /// </summary>
    public Contact Author { get; set; }
    public int AuthorId { get; set; }

    /// <summary>
    /// Doctor who participates in thread.
    /// </summary>
    public Contact? Participant { get; set; }
    public int ParticipantId { get; set; }

    /// <summary>
    /// Related <see cref="OnlineVisit"/> thread.
    /// </summary>
    public OnlineVisit? OnlineVisit { get; set; }
    public int OnlineVisitId { get; set; }
    
    /// <summary>
    /// Thread name (title).
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Is Thread closed.
    /// </summary>
    public bool IsClosed { get; set; }
    
    /// <summary>
    /// Is Doctor contact info shared.
    /// </summary>
    public bool IsContactShared { get; set; }

    /// <summary>
    /// Thread closed state info. <see cref="ThreadClosingState"/>
    /// </summary>
    public ThreadClosingState? ClosingState { get; set; }
    public int ClosingStateId { get; set; }

    public List<ThreadMessage> ThreadMessages { get; set; }
    
}



