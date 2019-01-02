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
        private List<Book> books;
        private List<Reader> readers;
        private List<Renting> rentings;
        private List<Book> availableBooks;
        private List<Author> authors;

        public Data()
        {
            librarians = new List<Librarian>();
            authors = new List<Author>();
            books = new List<Book>();
            readers = new List<Reader>();
            availableBooks = new List<Book>();
            rentings = new List<Renting>();
        }

        public Boolean addLibrarian(Librarian librarian)
        {
            var db = new MaintainDb();
            foreach (var l in librarians)
            {
                if (l.firstName == librarian.firstName && l.lastName == librarian.lastName)
                {
                    return false;
                }
            }
            librarians.Add(librarian);
            db.insertSingleObject(librarian);
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
                        ;
                    }
                    else librarians.Add(librarian);
                }

            }
            return true;
        }

        public Boolean readBooks()
        {
            var db = new MaintainDb();
            var booksFromDb = db.readBooks();
            foreach (var book in booksFromDb)
            {
                foreach (var bookStored in books)
                {
                    if (book.id == bookStored.id)
                    {
                        ;
                    }
                    else books.Add(book);
                }

            }
            return true;
        }

        public Boolean readReaders()
        {
            var db = new MaintainDb();
            var readersFromDb = db.readReaders();
            foreach (var reader in readersFromDb)
            {
                foreach (var readerStored in readers)
                {
                    if (reader.firstName == readerStored.firstName && reader.lastName == readerStored.lastName)
                    {
                        ;
                    }
                    else readers.Add(reader);
                }

            }
            return true;
        }

        public Boolean readRentings()
        {
            var db = new MaintainDb();
            var rentingsFromDb = db.readRentings();
            foreach (var renting in rentingsFromDb)
            {
                rentings.Add(renting);
            }
            return true;
        }

        public Boolean retriveAvailableBooks()
        {
            foreach (var book in books)
            {
                foreach (var renting in rentings)
                {
                    if (book.id == renting.itemId && renting.endDate != null)
                    {
                        ;
                    }
                    else availableBooks.Add(book);
                }
            }
            return true;
        }

        public List<Book> getAvailableBooks()
        {
            return this.availableBooks;
        }

        public Boolean addRenting(Renting renting)
        {
            var db = new MaintainDb();
            rentings.Add(renting);
            db.insertSingleObject(renting);
            return true;
        }

        public Boolean readAuthors()
        {
            var db = new MaintainDb();
            var authorsFromDb = db.readAuthors();
            foreach (var author in authorsFromDb)
            {
                foreach (var authorsStored in authors)
                {
                    if (author.firstName == authorsStored.firstName && author.lastName == authorsStored.lastName)
                    {
                        ;
                    }
                    else authors.Add(author);
                }

            }
            return true;
        }

        public List<Author> getAuthors()
        {
            return this.authors;
        }

        public List<Book> getBooks()
        {
            return this.books;
        }

        public Boolean addBook(Book book)
        {
            var db = new MaintainDb();
            foreach (var b in books)
            {
                if (b.id == book.id)
                {
                    ;
                }
            }
            books.Add(book);
            db.insertSingleObject(book);
            return true;
        }

        public Boolean addAuthor(Author author)
        {
            var db = new MaintainDb();
            if (authors.Count > 0) {
                foreach (var a in authors)
                {
                    if (a.firstName == author.firstName && a.lastName == author.lastName)
                    {
                        return false;
                    }
                }
            }
            authors.Add(author);
            db.insertSingleObject(author);
            return true;
        }


    }

    }

