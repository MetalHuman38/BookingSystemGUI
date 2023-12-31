using BookingSystem.MVVM.Model;
using BookingSystem.Repositories;
using Microsoft.EntityFrameworkCore;


public class BookingDbContext : DbContext
{
    private readonly RepositoryBaseClass _repositoryBase;

    public BookingDbContext()
    {
        _repositoryBase = new RepositoryBaseClass();
    }
    public DbSet<BookingHistory> BookingHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection string
        optionsBuilder.UseSqlServer(_repositoryBase.GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Specify the primary key for BookingHistory
        modelBuilder.Entity<BookingHistory>().HasKey(b => b.BookingID);

        // Add any other configurations here

        base.OnModelCreating(modelBuilder);
    }
}
