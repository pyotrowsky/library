using System;
using System.Collections;
using System.Collections.Generic;

namespace LibrarySolution
{
    public class Author : User
    {
        
        public String description { get; set; }

        public Author(String firstName, String lastName, String description) : base(firstName, lastName)
        {
            this.description = description;
        }



    }
}