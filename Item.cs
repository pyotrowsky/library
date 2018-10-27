using System; 

namespace Library {
    abstract class Item {

        protected String title;
        protected double size;
        protected Author author;
        protected DateTime creationDate;
        protected DateTime borrowedDate;
        protected String genre;
        protected String description;
        protected long refNo;
        protected String language;
        protected Boolean isBorrowed;
        protected Reader borrowedBy;

        protected Item(String title, long refNo) {
            this.title = title;
            this.refNo = refNo;
        }
        public String getTitle() {
            return this.title.Trim();
        }

        public void setTitle(String title) {
            this.title = title.Trim();
        }
         
         public double getSize() {
            return this.size;
        }

        public void setSize(double size) {
            this.size = size;
        }

        public DateTime getCreationDate() {
            return this.creationDate;
        }

        public void setCreationDate(DateTime creationDate) {
            this.creationDate = creationDate;
        }

         public DateTime getBorrowedDate() {
            return this.borrowedDate;
        }

        public void setBorrowedDate(DateTime borrowedDate) {
            this.borrowedDate = borrowedDate;
        }


        public void setAuthor(Author author) {
            this.author = author;
        }

        public String getGenre() {
            return this.genre;
        }

        public void setGenre(String genre) {
            this.genre = genre.Trim();
        }

         public String getDescription() {
            return this.description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

           public long getRefNo() {
            return this.refNo;
        }

        public void setRefNo(long refNo) {
            this.refNo = refNo;
        }

           public String getLanguage() {
            return this.language;
        }

        public void setLanguage(String language) {
            this.language = language;
        }

        public String getAuthorName() {
            return this.author.getFullName();
        }

        public Boolean getBorrowed() {
            return this.isBorrowed;
        }

        public Reader getBorrowedBy() {
            return this.borrowedBy;
        }

        public void setBorrowedBy(Reader borrowedBy) {
            this.borrowedBy = borrowedBy;
        }

        public void setBorrowed(Boolean isBorrowed) {
            this.isBorrowed = isBorrowed;
        }

    }
}