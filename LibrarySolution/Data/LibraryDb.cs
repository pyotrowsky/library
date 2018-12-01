using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LibrarySolution.Data
{
    [Database(Name="Library")]
    class LibraryDb : DataContext
    {
        public LibraryDb(string connection) : base(connection) { }
    }
}
