using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoGrpc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

   // public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
    public DbSet<ToDoItem> ToDoItems { get; set; }
}