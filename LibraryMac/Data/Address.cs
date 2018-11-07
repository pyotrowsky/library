using System;

namespace Library
{
    public class Address
    {

        private String street;
        private String town;
        private int postalCode;

        public Address(String street, String town, int postalCode)
        {
            this.street = street;
            this.town = town;
            this.postalCode = postalCode;
        }


        public String getStreet()
        {
            return this.street;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String getTown()
        {
            return this.town;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public int getPostalCode()
        {
            return this.postalCode;
        }

        public void setPostalCode(int postalCode)
        {
            this.postalCode = postalCode;
        }


    }
}