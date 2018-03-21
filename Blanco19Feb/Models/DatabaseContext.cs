using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blanco19Feb.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<ContactGroup> ContactGroup { get; set; }
}
}
