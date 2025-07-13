namespace solv_assignment_session_OOP03
{
    internal class Program
    {
        /*
        Step 5: Main Program – Demonstrating Polymorphism 
        • In the Main method: 
        o Create a List<Person>. 
        o Add at least: 
        ▪ Two Student objects 
        ▪ One Teacher object 
        ▪ One Admin object 
        • Loop through the list and call the GetDetails() method on each object.
        */
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            
            people.Add(new Student { firstName = "John", lastName = "Doe", age = 20, GradeLevel = "Sophomore" });
            people.Add(new Student { firstName = "Jane", lastName = "Smith", age = 22, GradeLevel = "Senior" });
        
            people.Add(new Teacher { firstName = "Alice", lastName = "Johnson", age = 35, Subject = "Mathematics" });
           
            people.Add(new Admin { firstName = "Bob", lastName = "Brown", age = 40, Role = "Coordinator" });
          
            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
        }
    }
}
