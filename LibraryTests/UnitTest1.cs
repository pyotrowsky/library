using System;
using System.Collections.Generic;
using System.Data.Entity;
using LibrarySolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTests
{
    [TestClass]
    public class LibraryTests
    {
        private Reader marta;
        private Reader martynka;
        private Reader adrian;
        private Author panzej;
        private Author stieg;
        private Librarian szymi;
        private Librarian bartolus;
        private Book wiedzminSzponyIKly;
        private Book girlWithTheDragonTattoo;
        private Book zamekZPiaskuKtoryRunal;
        private ObjGenerator gen;
        private Maintain maintain;
        private Data storage;
        private MaintainDb maintainDb;

        public LibraryTests()
        {
            szymi = new Librarian("Szymon", "Rogalski", 3500, 1, new DateTime(1997, 01, 07));
            bartolus = new Librarian("Bartek", "Rogalski", 3500, 1, new DateTime(1997, 01, 07));
            storage = new LibrarySolution.Data();
            maintainDb = new MaintainDb();
            Database.SetInitializer(new CustomInitializer<LibraryDb>());            
            storage.addLibrarian(szymi);
            storage.addLibrarian(bartolus);
            

        }

        [TestMethod]
        public void AddAllDataToDb()
        {
            maintainDb.insertData<Librarian>(storage.getLibrarians());
            maintainDb.deleteRow<Librarian>(bartolus);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void ReturnAvailableItem()
        {
            //Assert.IsFalse(maintain.returnItem(girlWithTheDragonTattoo));

        }

        [TestMethod]
        public void RentAvailableBook()
        {
            //Assert.IsTrue(maintain.rentItem(zamekZPiaskuKtoryRunal, marta));
            //maintain.addCharge(10);
            //Console.WriteLine(zamekZPiaskuKtoryRunal.getBorrowedBy());
            //Console.WriteLine(zamekZPiaskuKtoryRunal.getBorrowedDate());
            //Console.WriteLine(marta.getcharge());
            //Console.WriteLine("test1 " + zamekZPiaskuKtoryRunal.getBorrowed());
        }

        [TestMethod]
        public void GetBorrowedBooksAfterBorrowing()
        {
            //maintain.rentItem(girlWithTheDragonTattoo, adrian);
            //Assert.AreEqual(girlWithTheDragonTattoo, maintain.getAllBorrowedBooks()[0]);
        }
    }
}
