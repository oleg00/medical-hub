using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MedicalHub.DAL;

namespace MedicalHub.WebApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<ThreadClosingState> ClosingStates { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    
    }
}