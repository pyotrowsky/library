using System;

namespace LibrarySolution
{
    public class Address
    {
        public int id { get; set; }
        public String street { get; set; }
        public String town { get; set; }
        public int postalCode { get; set; }

        public Address(String street, String town, int postalCode)
        {
            this.street = street;
            this.town = town;
            this.postalCode = postalCode;
        }


        

    }
}