using Assignment2.Shared;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Server.DB
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
        public DbSet<Reviews> Reviews { get; set; }
    }
}
