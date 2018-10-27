using System;
using System.Collections.Generic;

namespace Library {
     class Reader { 
     
     Address address;
     DateTime joinDate;
     List <Item> borrowedItems;
    private double charge;

    public DateTime getJoinDate() {
        return this.joinDate; 
    }

    public void setJoinDate (DateTime joinDate) {
        this.joinDate = joinDate; 
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