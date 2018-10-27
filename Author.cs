using System;
using System.Collections;
using System.Collections.Generic;

namespace Library {
    class Author: User {

        private List<String> books;
        private String description;
        
        private List<String> genres;

        public Author(){
        
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