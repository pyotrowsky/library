using System;

namespace Library
{
    public abstract class Item
    {

        protected String title;
        protected Author author;
        protected int creationDate;
        protected DateTime borrowedDate;
        protected String genre;
        protected String description;
        protected long refNo;
        protected String language;
        protected Boolean isBorrowed;
        protected Reader borrowedBy;

        public Item(String title, long refNo, Author author, int creationDate,
        String genre, String language)
        {
            this.title = title;
            this.refNo = refNo;
            this.author = author;
            this.creationDate = creationDate;
            this.genre = genre;
            this.language = language;
        }

        public Boolean getBorrowed()
        {
            return this.isBorrowed;
        }

        public String getTitle()
        {
            return this.title.Trim();
        }

        public void setTitle(String title)
        {
            this.title = title.Trim();
        }

        public int getCreationDate()
        {
            return this.creationDate;
        }

        public void setCreationDate(int creationDate)
        {
            this.creationDate = creationDate;
        }

        public DateTime getBorrowedDate()
        {
            return this.borrowedDate;
        }

        public void setBorrowedDate(DateTime borrowedDate)
        {
            this.borrowedDate = borrowedDate;
        }


        public void setAuthor(Author author)
        {
            this.author = author;
        }

        public String getGenre()
        {
            return this.genre;
        }

        public void setGenre(String genre)
        {
            this.genre = genre.Trim();
        }

        public String getDescription()
        {
            return this.description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public long getRefNo()
        {
            return this.refNo;
        }

        public void setRefNo(long refNo)
        {
            this.refNo = refNo;
        }

        public String getLanguage()
        {
            return this.language;
        }

        public void setLanguage(String language)
        {
            this.language = language;
        }

        public String getAuthorName()
        {
            return this.author.getFullName();
        }



        public Reader getBorrowedBy()
        {
            return this.borrowedBy;
        }

        public void setBorrowedBy(Reader borrowedBy)
        {
            this.borrowedBy = borrowedBy;
        }

        public void setBorrowed(Boolean isBorrowed)
        {
            this.isBorrowed = isBorrowed;
        }
    }
}