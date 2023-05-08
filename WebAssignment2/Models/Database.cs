using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace WebAssignment2.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
        public DbSet<Reviews> Reviews { get; set; }
    }
}
