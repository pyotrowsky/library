using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySolution
{
    public class MaintainDb
    {
        private LibraryDb db;
        public MaintainDb()
        {
            db = new LibraryDb();
        }

        public void insertData<T>(List<T> data)
        {
           

            if(!db.Librarians.Any() && data is List<Librarian>)
            {
                foreach (var librarian in data.Cast<Librarian>().ToList())
                {
                    db.Librarians.Add(librarian);
                }
            }

            else if (!db.Books.Any() && data is List<Book>)
            {
                foreach (var book in data.Cast<Book>().ToList())
                {
                    db.Books.Add(book);
                }
            }

            else if (!db.Readers.Any() && data is List<Reader>)
            {
                foreach (var reader in data.Cast<Reader>().ToList())
                {
                    db.Readers.Add(reader);
                }
            }

            else if (!db.Authors.Any() && data is List<Author>)
            {
                foreach (var author in data.Cast<Author>().ToList())
                {
                    db.Authors.Add(author);
                }
            }
            else if (!db.Addresses.Any() && data is List<Address>)
            {
                foreach (var address in data.Cast<Address>().ToList())
                {
                    db.Addresses.Add(address);
                }
            }

            db.SaveChanges();
        }

        public void insertSingleObject<T>(T obj)
        {

            if (obj is Address)
            {
                db.Addresses.Add((Address)(object)obj);
            }
            else if (obj is Librarian)
            {
                db.Librarians.Add((Librarian)(object)obj);
            }
            else if (obj is Author)
            {
                db.Authors.Add((Author)(object)obj);
            }
            else if (obj is Reader)
            {
                db.Readers.Add((Reader)(object)obj);
            }
            else if (obj is Book)
            {
                db.Books.Add((Book)(object)obj);
            }
            db.SaveChanges();
        }

        public void deleteRow<T>(T obj)
        {
            if (obj is Address)
            {
                db.Addresses.Remove((Address)(object)obj);
            }
            else if (obj is Librarian)
            {
                db.Librarians.Remove((Librarian)(object)obj);
            }
            else if (obj is Author)
            {
                db.Authors.Remove((Author)(object)obj);
            }
            else if (obj is Reader)
            {
                db.Readers.Remove((Reader)(object)obj);
            }
            else if (obj is Book)
            {
                db.Books.Remove((Book)(object)obj);
            }
            db.SaveChanges();
        }

        public List<Librarian> readLibrarians()
        {
            var db = new LibraryDb();
            var librariansFromDb = new List<Librarian>();
            if (db.Librarians.Any())
            {
                var query = from librarian in db.Librarians
                            select librarian;
                foreach (var librarian in query)
                {
                    librariansFromDb.Add(librarian);
                }
            }
            return librariansFromDb;


        }

        public List<Librarian> readLibrariansStartingWith(String start)
        {
            var db = new LibraryDb();
            var librariansFromDb = new List<Librarian>();
            if (db.Librarians.Any())
            {
                var query = from librarian in db.Librarians
                            where librarian.firstName.StartsWith(start)
                            select librarian;
                foreach (var librarian in query)
                {
                    librariansFromDb.Add(librarian);
                }
            }
            return librariansFromDb;


        }

    }
}
