using entities.models;
using Microsoft.EntityFrameworkCore;

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