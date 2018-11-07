using System;

namespace Library
{
    public abstract class User
    {
        protected String firstName { get; set; }
        protected String lastName { get; set; }
        protected int refNo { get; set; }

        public User(String firstName, String lastName, int refNo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.refNo = refNo;
        }


        //     public String getFirstname()
        // {
        //  return this.firstName.Trim();
        // }

        // public void setFirstname(String firstName)
        // {
        //  this.firstName = firstName.Trim();
        // }

        /*public String getLastname()
        {
            return this.lastName.Trim();
        }

        public int getRefno()
        {
            return this.refNo;
        }*/

        public String getFullName()
        {
            return this.firstName.Trim() + " " + this.lastName.Trim();
        }

    }

}
