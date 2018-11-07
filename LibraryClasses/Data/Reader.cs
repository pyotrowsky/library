using System;
using System.Collections.Generic;

namespace Library {
    public class Reader : User { 
     
        Address address { get; set; }
        DateTime joinDate { get; }
        List<Item> borrowedItems { get; }
        private double charge { get; set; }

        public Reader(Address address, String firstName, String lastName, int refNo) : base (firstName, lastName, refNo)
        {
            this.address = address;
            joinDate = DateTime.Today;
            borrowedItems = new List<Item>();
            charge = 0;
        }

    public DateTime getJoinDate() {
        return this.joinDate; 
    }

     public double getcharge() {
        return this.charge; 
    }

    public void addCharge (double charge) {
        this.charge += charge;
    }

    public void setAddress (Address address) {
        this.address = address;
    }

    public List<Item> getBorrowedItems() {
        return this.borrowedItems;
    }

    public void addBorrowedItem(Item item) {
        this.borrowedItems.Add(item);
    }

    public void removeBorrowedItem(Item item) {
        foreach(Item book in this.borrowedItems) {
            if (book.getRefNo() == item.getRefNo()) {
                borrowedItems.Remove(item);
            }
        }
    }

     }
}