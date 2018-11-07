using System;

namespace Library
{
    public class Book : Item
    {
        private int numberOfPages;

        public Book(String title, long refNo, Author author, int creationDate,
        String genre, String language, int numberOfPages) : base(title, refNo, author, creationDate, genre, language)
        {
            this.numberOfPages = numberOfPages;
        }
        public int getNumberOfPages()
        {
            return this.numberOfPages;
        }

        public void setNumberOfPages(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

    }
}
