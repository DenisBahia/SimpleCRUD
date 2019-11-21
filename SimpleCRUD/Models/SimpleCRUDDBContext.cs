using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class SimpleCRUDDBContext: DbContext
    {
        public SimpleCRUDDBContext(DbContextOptions<SimpleCRUDDBContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
