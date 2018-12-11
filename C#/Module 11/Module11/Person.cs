using System;
using System.Collections.Generic;
using System.Text;

namespace Module11
{
    public enum Gender
    {
        Male, Female, Other
    }

    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }


    }
}
