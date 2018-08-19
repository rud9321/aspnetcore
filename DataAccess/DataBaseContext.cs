using coreapp2._0.Models;
using coreapp2.Models;
using Microsoft.EntityFrameworkCore;
namespace coreapp2._0.DataAccess
{   
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        public DbSet<student> Students{get;set;}    
    }
}