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
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
        }
        public virtual string GetDetails()
        {
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }
}
