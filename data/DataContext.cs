
using Microsoft.EntityFrameworkCore;
using SmsDotNet.Entities;

namespace SmsDotNet.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            :base(options)
        {
        }

        public DbSet<UserModel> User { get; set; }

    }
}