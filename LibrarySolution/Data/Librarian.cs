using System;
using System.Collections;
using System.Collections.Generic;

namespace LibrarySolution
{
    public class Librarian : User
    {
        public double salary { get; set; }
        public DateTime startDate { get; set; }
        public DateTime birthday { get; set; }
        public int addressId { get; set; }

        public Librarian(String firstName, String lastName, double salary, int addressId, DateTime birthday) : base(firstName, lastName)
        {
            this.salary = salary;
            this.addressId = addressId;
            this.birthday = birthday;
            startDate = DateTime.Today;
        }

    }
}