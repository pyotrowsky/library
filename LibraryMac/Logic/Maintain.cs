using System;
using System.Collections.Generic;

namespace Library
{
    public class Maintain
    {

        private List<Item> allItems;
        private int limit { get; set; }

        public Maintain()
        {
            this.limit = 1;
            allItems = new List<Item>();
        }

        public List<Item> gettAllItems()
        {
            return this.allItems;
        }

        public void addItem(Item item)
        {
            this.allItems.Add(item);
        }

        public List<Item> getAllAvailableBooks()
        {
            List<Item> availableBooks = new List<Item>();

            foreach (Item item in this.allItems)
            {
                Boolean isBorrowed = item.getBorrowed();
                if (isBorrowed.Equals(false))
                {
                    availableBooks.Add(item);
                }
            }
            return availableBooks;
        }

        public List<Book> getAllBorrowedBooks()
        {
            List<Book> borrowedBooks = new List<Book>();

            foreach (Book item in this.allItems)
            {
                Boolean isBorrowed = item.getBorrowed();
                if (isBorrowed.Equals(true))
                {
                    borrowedBooks.Add(item);
                }
            }
            return borrowedBooks;
        }
        public Boolean rentItem(Item item, Reader reader)
        {
            if (item.getBorrowed().Equals(true))
            {
                return false;
            }
            else
            {
                item.setBorrowed(true);
                reader.addBorrowedItem(item);
                item.setBorrowedBy(reader);
                item.setBorrowedDate(DateTime.Now);
                return true;
            }
        }

        public Boolean returnItem(Item item)
        {
            if (item.getBorrowed().Equals(false))
            {
                return false;
            }
            else
            {
                Reader user = item.getBorrowedBy();
                user.removeBorrowedItem(item);
                item.setBorrowed(false);
                item.setBorrowedBy(null);
                return true;
            }
        }

        public void addCharge(int charge)
        { //designated to run every 24h
            List<Book> books = getAllBorrowedBooks();

            foreach (Book item in books)
            {
                DateTime currentDate = DateTime.Now;
                Console.WriteLine(currentDate);
                Reader user = item.getBorrowedBy();
                int totalDays = (currentDate - item.getBorrowedDate()).Days;
                Console.WriteLine(totalDays);
                if (totalDays > this.limit)
                {
                    user.addCharge(charge);
                }
            }
        }
    }
}