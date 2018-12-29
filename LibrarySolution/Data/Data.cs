using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySolution
{
    public class Data
    {
        private List<Librarian> librarians;

        public Data()
        {
            librarians = new List<Librarian>();
        }

       public Boolean addLibrarian(Librarian librarian)
        {
            foreach (var l in librarians)
            {
                if (l.firstName == librarian.firstName && l.lastName == librarian.lastName)
                {
                    return false;
                }
            }
            librarians.Add(librarian);
            return true;
        }

        public List<Librarian> getLibrarians()
        {
            return this.librarians;
        }

        public Boolean readLibrarians()
        {
            var db = new MaintainDb();
            var librariansFromDb = db.readLibrarians();
            foreach (var librarian in librariansFromDb)
            {
                foreach (var librarianStored in librarians)
                {
                    if (librarian.firstName == librarianStored.firstName && librarian.lastName == librarianStored.lastName)
                    {
                        break;
                    }
                }
                librarians.Add(librarian);
            }
            return true;
        }
    }
}
