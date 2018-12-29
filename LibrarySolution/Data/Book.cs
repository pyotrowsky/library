using System;

namespace LibrarySolution
{
    public class Book : Item
    {
        public int numberOfPages { get; set; }

        public Book(String title, int authorId, int creationDate, String language, int numberOfPages) : base(title, authorId, creationDate, language)
        {
            this.numberOfPages = numberOfPages;
        }
    }
}
