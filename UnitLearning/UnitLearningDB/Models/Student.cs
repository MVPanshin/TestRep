namespace UnitLearningDB
{
    public class Student
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LatinName { get; set; }
        public string email { get; set; }

        public virtual Company Company { get; set; }
    }
}