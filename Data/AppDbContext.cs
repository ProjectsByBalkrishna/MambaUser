using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using MambaUser.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MambaUser.Data{
    public class AppDbContext: DbContext{
        public AppDbContext(DbContextOptions option):base(option)
        {
            
        }

public DbSet<LoginUser> Users { get; set; }
public DbSet<Admina> Admins { get; set; }
public DbSet<books> Books { get; set; }
// public DbSet<Category> Categories { get; set; }
    }
}