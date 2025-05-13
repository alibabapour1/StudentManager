namespace StudentManagement.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Average { get; set; }
        public Fields Field { get; set; }



        private Student(string firstName, string lastName, double average, Fields fields)
        {
            FirstName = firstName;
            LastName = lastName;
            Average = average;
            Field = fields;
        }

        public static Student Create(string firstName, string lastName, double average, Fields fields)
        {
            if (firstName == null || lastName == null)
                throw new ArgumentNullException("FirstName or LastName Cannot Be Null");

            return new Student(firstName, lastName, average, fields);
        }




    }


}
