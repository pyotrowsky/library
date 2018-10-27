using System;
using System.Collections.Generic;

namespace Library {
     class Maintain { 
     
     private List<Item> allItems;
     private int limit {get; set;}
     private double charge {get; set;}
     public List<Item> gettAllItems() {
         return this.allItems;
     }

     public void addItem(Item item) {
         this.allItems.Add(item);
     }

    public List<Item> getAllAvailableBooks() {
        List<Item> availableBooks = new List<Item>();

        foreach(Item item in this.allItems) {
            Boolean isBorrowed = item.getBorrowed();
            if(isBorrowed.Equals(false)) {
                availableBooks.Add(item);
            }
        }
        return availableBooks;
    }

    public List<Item> getAllBorrowedBooks() {
        List<Item> borrowedBooks = new List<Item>();

        foreach(Item item in this.allItems) {
            Boolean isBorrowed = item.getBorrowed();
            if(isBorrowed.Equals(true)) {
                borrowedBooks.Add(item);
            }
        }
        return borrowedBooks;
    }
    public Boolean rentItem(Item item, Reader reader) {
        if(item.getBorrowed().Equals(false)) {
            return false;
        }
        else {
            item.setBorrowed(true);
            reader.addBorrowedItem(item);
            return true;
        }
    }

    public Boolean returnItem(Item item) {
        if(item.getBorrowed().Equals(true)) {
            return false;
        }
        else {
            Reader user = item.getBorrowedBy();
            user.removeBorrowedItem(item);
            item.setBorrowed(false);
            return true;
        }
    }

    public void addCharge() { //designated to run every 24h
        List<Item> books =  getAllBorrowedBooks();

        foreach(Item item in books) { 
            DateTime currentDate = new DateTime();
            Reader user = item.getBorrowedBy();
            int totalDays = (currentDate - item.getBorrowedDate()).Days;
            if (totalDays > this.limit) {
                user.addCharge(this.charge);
            }
        }
    }
    public static void Main() {
         Book book = new Book("Adrian i Marta", 1, 123);
         Console.WriteLine(book.getTitle());
    }
    }
}