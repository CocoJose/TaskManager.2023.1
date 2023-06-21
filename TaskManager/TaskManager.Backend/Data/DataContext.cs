using Microsoft.EntityFrameworkCore;
using TaskManagerShared.Entities;

namespace TaskManager.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {    
        }

        public DbSet<MyTask> MyTasks { get; set; }
    }
}
