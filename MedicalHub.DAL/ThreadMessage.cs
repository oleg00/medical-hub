namespace MedicalHub.DAL;

/// <summary>
/// Message in a <see cref="Thread"/> model. 
/// </summary>
public class ThreadMessage
{

    public Guid Id { get; set; }
    
    /// <summary>
    /// Related thread reference.
    /// </summary>
    public Thread Thread { get; set; }

    public int ThreadId { get; set; }
    
    /// <summary>
    /// Encrypted text.
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// Author contact reference.
    /// </summary>
    public Contact Contact { get; set; }

    public int ContactId { get; set; }
    
}
