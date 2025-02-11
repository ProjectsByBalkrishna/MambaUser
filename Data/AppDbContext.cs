using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using MambaUser.Models;

namespace MambaUser.Data{
    public class AppDbContext: DbContext{
        public AppDbContext(DbContextOptions option):base(option)
        {
            
        }

public DbSet<LoginUser> Users { get; set; }
public DbSet<books> Books { get; set; }

    }
}