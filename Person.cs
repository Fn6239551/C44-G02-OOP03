using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_assignment_session_OOP03
{
    /*
    Step 1: Create a Base Class – Person 
    • Create a class named Person. 
    • Define private fields for the following attributes: 
    o FirstName (string) 
    o LastName (string) 
    o Age (int) 
    • Create public properties for all the fields using getters and setters. 
    • Add a constructor that initializes all the fields. 
    • Create a virtual method named GetDetails() that returns a formatted string 
    with the full name and age.
    */
    internal class Person
    {
        public int Age { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public virtual string GetDetails()
        {
            return $"Name: {firstName} {lastName}, Age: {Age}";
        }
    }
}
