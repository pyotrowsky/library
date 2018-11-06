using System;
using System.Collections;
using System.Collections.Generic;

namespace Library {
    public class Author: User {

        private List<String> books;
        private String description { get; set; }
        private List<String> genres;

        public Author(String firstName, String lastName, int refNo) : base(firstName, lastName, refNo)
        {
            books = new List<String>();
            genres = new List<string>();
        }

        public void addBook (String book) {
            this.books.Add(book);
        }

        public List<String> getBooks() {
            return books;
        }

        public void addGenre (String genre) {
            this.genres.Add(genre);
        }

        public List<String> getGenres() {
            return genres;
        }


    }
}