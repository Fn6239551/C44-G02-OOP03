using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_assignment_session_OOP03
{
    /*
     Step 4: Create a Derived Class – Admin 
     • Inherit from the Person class. 
     • Add a public property named Role (string), which can be values like 
     "Coordinator" or "Secretary". 
     • Override the GetDetails() method to include the admin’s role in the output. 
     */
    internal class Admin : Person
    {
        public string? Role { get; set; }
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Role: {Role}";
        }
    }
}
