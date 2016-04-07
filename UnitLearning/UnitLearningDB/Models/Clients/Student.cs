namespace UnitLearningDB
{
    public class Student : BaseMan
    {
        public int StudentID { get; set; }
        public string LatinName { get; set; }
        public string email { get; set; }

        public virtual Company Company { get; set; }
    }
}