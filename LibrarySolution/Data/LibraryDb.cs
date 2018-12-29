using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.Entity;

namespace LibrarySolution
{

   public class LibraryDb : DbContext
    {
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Address> Addresses { get; set; }

       

    }
}
