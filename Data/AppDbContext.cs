using Microsoft.EntityFrameworkCore;
using RestfulApiProject.Models;

namespace RestfulApiProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}

