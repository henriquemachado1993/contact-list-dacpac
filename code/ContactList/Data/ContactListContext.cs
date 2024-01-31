using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactList.Models;

namespace ContactList.Data
{
    public class ContactListContext : DbContext
    {
        public ContactListContext (DbContextOptions<ContactListContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ContactList.Models.Contacts> Contacts { get; set; }
    }
}
