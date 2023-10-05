using Microsoft.EntityFrameworkCore;

namespace CourseSite.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Publication> Publications { get; set; }
    public DbSet<Coment> Coments { get; set; }
}
