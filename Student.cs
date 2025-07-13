using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_assignment_session_OOP03
{
    /*
    Step 2: Create a Derived Class – Student 
    • Inherit from the Person class. 
    • Add a public property named GradeLevel (string). 
    • Override the GetDetails() method to include the student’s grade level in the output. 
     */
    internal class Student: Person
    {
        public string? GradeLevel { get; set; }
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Grade Level: {GradeLevel}";
        }
    }
}
