using Gestao.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Repo;

public class DataContext : DbContext
{
    public string DbPath { get; }
    public DbSet<Filme> Filme { get; set; }
    public DbSet<Teste> Teste { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teste>().HasKey(x => x.Id);
        base.OnModelCreating(modelBuilder);
    }
}