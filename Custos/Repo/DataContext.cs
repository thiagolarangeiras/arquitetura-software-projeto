using Custos.Models;
using Microsoft.EntityFrameworkCore;

namespace Custos.Repo;

public class DataContext : DbContext
{
    public string DbPath { get; }
    public DbSet<Custo> Custo { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Custo>().HasKey(x => x.Id);
        base.OnModelCreating(modelBuilder);
    }
}