using System.Runtime.CompilerServices;
using MedicalHub.DAL.Enumerations;
using SQLitePCL;

namespace MedicalHub.WebApp.Services;
using MedicalHub.DAL;

public class ThreadDataService
{

    private Contact _author = new()
    {  
        Email = "author@gmail.com",
        Name = "AuthorName",
        PhoneNumber = "+3801337",
        UserType = UserType.Patient,
        ImageUrl = "https://i.pinimg.com/474x/c4/66/90/c466907bfa75c5598d6a193a589531a4.jpg"
    };
    
    private Contact _participant = new Contact
    {  
        Email = "participant@gmail.com",
        Name = "ParticipantName",
        PhoneNumber = "+38013372",
        UserType = UserType.Doctor,
        ImageUrl = "https://media.istockphoto.com/photos/good-health-is-important-picture-id676515066?k=20&m=676515066&s=612x612&w=0&h=BVoFlJjyyxCT6OdjaVN7bp_zNA2RXZ3EcRV9qcoWNkk="
    };
    
    // Mock.
    private List<Thread> _threads = new List<Thread>()
    {
        new Thread()
        {
            Name = "myasshurtshelpmepls",
            ThreadMessages = new List<ThreadMessage>()
            {
                new ThreadMessage()
                {
                    Text = "PLS HELP ME!!!"
                }   
            }
        }
    };
    
    public ThreadDataService()
    {
        _threads[0].Author = _author;
        _threads[0].Participant = _participant;
    }

    public List<Thread> FetchThreads()
    {
        return _threads;
    }
    
    
    
}