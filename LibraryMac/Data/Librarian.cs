using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Librarian : User
    {

        private double salary { get; set; }

        private DateTime startDate { get; set; }

        private DateTime birthday { get; set; }
        Address address { get; set; }

        public Librarian(String firstName, String lastName, int refNo, double salary, Address address, DateTime birthday) : base(firstName, lastName, refNo)
        {
            this.salary = salary;
            this.address = address;
            this.birthday = birthday;
            startDate = DateTime.Today;
        }
        /*public DateTime getBirthday()
        {
            return this.birthday;
        }

        public void setBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime getStartdate () {
            return this.startDate; 
        }

        public void setStartdate (DateTime startDate) {
            this.startDate = startDate; 
        }


        public double getSalary() {
            return this.salary; 
        }

        public void setSalary (double salary) {
            this.salary = salary; 
        }

        public void setAddress (String street, String town, int postalCode) {
            this.address.setStreet(street);
            this.address.setTown(town);
            this.address.setPostalCode(postalCode);
        }*/


    }
}