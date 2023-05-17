using BooKeeper.Data;
using System.Windows.Forms;

public class DbInitialiser
{
    private readonly BookDbContext _context;

    public DbInitialiser(BookDbContext context)
    {
        _context = context;
    }

    public void Run()
    {
        _context.Database.EnsureCreated();
    }
}