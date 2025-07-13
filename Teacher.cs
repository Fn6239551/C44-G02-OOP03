using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_assignment_session_OOP03
{
    /*
     Step 3: Create a Derived Class – Teacher 
     • Inherit from the Person class. 
     • Add a public property named Subject (string). 
     • Override the GetDetails() method to include the teacher’s subject in the output. 
     */
    internal class Teacher: Person
    {
       
        public string? Subject { get; set; }
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Subject: {Subject}";
        }

    }
}
