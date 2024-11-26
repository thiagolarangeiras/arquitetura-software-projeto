using Elenco.Models;
using Microsoft.EntityFrameworkCore;

namespace Elenco.Repo;

public class DataContext : DbContext
{
    public string DbPath { get; }
    public DbSet<Atores> Atores { get; set; }
    public DbSet<AtorFilme> AtorFilme { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atores>().HasKey(x => x.Id);
        modelBuilder.Entity<AtorFilme>().HasKey(x => x.Id);
        base.OnModelCreating(modelBuilder);
    }
}