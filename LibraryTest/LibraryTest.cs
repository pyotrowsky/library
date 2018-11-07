using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library
{
    [TestClass]
    public class LibraryTest
    {
        private Reader marta;
        private Reader adrian;
        private Author panzej;
        private Author stieg;
        private Librarian szymi;
        private Librarian bartolus;
        private Book wiedzminSzponyIKly;
        private Book girlWithTheDragonTattoo;
        private Book zamekZPiaskuKtoryRunal;

        private Maintain maintain;

        public LibraryTest()
        {
            marta = new Reader(new Address("Jaracza", "Lodz", 90001), "Marta", "Brzozowska", 001);
            adrian = new Reader(new Address("Jakas", "Brzeziny", 95001), "Adrian", "Piotrowski", 002);
            panzej = new Author("Andrzej", "Sapkowski", 101);
            stieg = new Author("Stieg", "Larsson", 102);
            szymi = new Librarian("Szymon", "Rogalski", 201, 4500, new Address("Dabrowskiego", "Lodz", 93100), new DateTime(1997, 1, 16));
            bartolus = new Librarian("Bartek", "Spakowski", 202, 3500, new Address("Darniowa", "Lodz", 93200), new DateTime(199, 3, 10));
            wiedzminSzponyIKly = new Book("Wiedzmin: Szpony i Kly", 9001, panzej, 2017, "Fantasy", "Polish", 395);
            girlWithTheDragonTattoo = new Book("The Girl with the Dragon Tattoo", 9002, stieg, 2012, "Thriller", "English", 700);
            zamekZPiaskuKtoryRunal = new Book("Zamek z Piasku, Ktory Runal", 9003, stieg, 2015, "Thriller", "Polish", 500);

            maintain = new Maintain();

            maintain.addItem(wiedzminSzponyIKly);
            maintain.addItem(girlWithTheDragonTattoo);
            maintain.addItem(zamekZPiaskuKtoryRunal);
        }

        [TestMethod]
        public void RentBorrowedBook()
        {
            maintain.rentItem(wiedzminSzponyIKly, marta);
            Assert.IsFalse(maintain.rentItem(wiedzminSzponyIKly, adrian));
        }

        [TestMethod]
        public void  ReturnAvailableItem()
        {
            Assert.IsFalse(maintain.returnItem(girlWithTheDragonTattoo));
        }

        [TestMethod]
        public void RentAvailableBook()
        {
            Assert.IsTrue(maintain.rentItem(zamekZPiaskuKtoryRunal, marta));
        }

        [TestMethod]
        public void ReturnRentedBook()  //Nie przechodzi, odwrotny test przechodzi wiec nie wiem co jest 5
        {
            Assert.IsTrue(maintain.returnItem(zamekZPiaskuKtoryRunal));
        }

        [TestMethod]
        public void GetBorrowedBooksAfterBorrowing()
        {
            maintain.rentItem(girlWithTheDragonTattoo, adrian);
            Assert.AreEqual(girlWithTheDragonTattoo, maintain.getAllBorrowedBooks()[0]);
        }
    }
}
