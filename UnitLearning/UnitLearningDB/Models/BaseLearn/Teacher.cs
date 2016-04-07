using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Teacher : BaseMan
    {
        public int TeacherID { get; set; }

        public virtual IEnumerable<Course> AvailableCourses { get; set; }
        public string StatusList { get; set; }
    }
}