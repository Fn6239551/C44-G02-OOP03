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
           
            people.Add(new Student { firstName = "John", lastName = "Doe", Age = 17, GradeLevel = "Grade 11" });
            people.Add(new Student { firstName = "Jane", lastName = "Smith", Age = 22, GradeLevel = "Senior" });
            
            people.Add(new Teacher { firstName = "Alice", lastName = "Johnson", Age = 35, Subject = "Mathematics" });
            
            people.Add(new Admin { firstName = "Bob", lastName = "Brown", Age = 40, Role = "Coordinator" });
            

            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }

        }
    }
}
