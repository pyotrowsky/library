using System;

namespace Library {
    class Book: Item {
    private int numberOfPages;

    public Book(String title, long refNo, int numberOfPages) : base(title, refNo) {
        this.numberOfPages = numberOfPages;

    }
    public int getNumberOfPages() {
        return this.numberOfPages;
    }

    public void setNumberOfPages(int numberOfPages) {
        this.numberOfPages = numberOfPages;
    }

    }
}
