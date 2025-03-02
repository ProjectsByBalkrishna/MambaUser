using Microsoft.EntityFrameworkCore;
using MambaUser.Models;

namespace MambaUser.Data{
    public class AppDbContext: DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {
            
        }

public DbSet<LoginUser> Users { get; set; }
public DbSet<Admin> Admins { get; set; }
public DbSet<books> Books { get; set; }
public DbSet<IssueBook> IssueBooks { get; set; }

    }
}