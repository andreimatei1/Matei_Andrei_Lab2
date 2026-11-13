using Microsoft.EntityFrameworkCore;

public class Matei_Andrei_Lab2Context(DbContextOptions<Matei_Andrei_Lab2Context> options) : DbContext(options)
{
    public DbSet<Matei_Andrei_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Matei_Andrei_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Matei_Andrei_Lab2.Models.Author> Author { get; set; } = default!;



}
