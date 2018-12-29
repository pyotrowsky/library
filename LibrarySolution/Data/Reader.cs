using System;
using System.Collections.Generic;

namespace LibrarySolution
{
    public class Reader : User
    {

        public int addressId { get; set; }
        DateTime joinDate { get; set; }

        public Reader(int addressId, String firstName, String lastName) : base(firstName, lastName)
        {
            this.addressId = addressId;
            joinDate = DateTime.Today;
        }
    }
}