using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySolution
{
    public abstract class User
    {
        
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        

        public User(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public String getFullName()
        {
            return this.firstName.Trim() + " " + this.lastName.Trim();
        }

    }

}
